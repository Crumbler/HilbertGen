using System;
using System.Collections.Generic;
using System.Linq;

namespace HilbertGen
{
    public class HilbertGrid
    {
        public HilbertCell[,] Grid
        {
            get;
            private set;
        }

        public HilbertGrid()
        {
            Grid = new HilbertCell[2, 2];
        }

        /// <summary>
        /// Generates a 2^size by 2^size grid
        /// </summary>
        public void Generate(int size)
        {
            (int x, int y) prev = (0, 0), curr;

            int cellsPerSide = 1 << size;
            int totalCells = cellsPerSide * cellsPerSide;

            Grid = new HilbertCell[cellsPerSide, cellsPerSide];

            for (int i = 1; i < totalCells; ++i)
            {
                curr = GetCoordsByInd(i, cellsPerSide);

                ConnectCells(prev, curr);

                prev = curr;
            }
        }

        private void ConnectCells((int x, int y) cellA, (int x, int y) cellB)
        {
            if (cellA.x < cellB.x)
            {
                Grid[cellA.y, cellA.x] |= HilbertCell.Right;
                Grid[cellB.y, cellB.x] |= HilbertCell.Left;
            }
            else if (cellA.x > cellB.x)
            {
                Grid[cellA.y, cellA.x] |= HilbertCell.Left;
                Grid[cellB.y, cellB.x] |= HilbertCell.Right;
            }
            else if (cellA.y > cellB.y)
            {
                Grid[cellA.y, cellA.x] |= HilbertCell.Top;
                Grid[cellB.y, cellB.x] |= HilbertCell.Bottom;
            }
            else
            {
                Grid[cellA.y, cellA.x] |= HilbertCell.Bottom;
                Grid[cellB.y, cellB.x] |= HilbertCell.Top;
            }
        }

        private static readonly (int x, int y)[] basePositions = new(int x, int y)[4]
        {
            (0, 0),
            (0, 1),
            (1, 1),
            (1, 0)
        };
        
        private static (int x, int y) GetCoordsByInd(int hIndex, int cellsPerSide)
        {
            var res = basePositions[hIndex & 3];
            hIndex >>= 2;

            for (int n = 4; n <= cellsPerSide; n *= 2)
            {
                int nHalf = n / 2;

                switch (hIndex & 3)
                {
                    // bottom-left corner
                    case 0:
                        (res.x, res.y) = (res.y, res.x);
                        break;

                    // top-left corner
                    case 1:
                        res.y += nHalf;
                        break;

                    // top-right corner
                    case 2:
                        res.x += nHalf;
                        res.y += nHalf;
                        break;

                    // bottom-right corner
                    case 3:
                        int tmp = res.y;
                        res.y = nHalf - 1 - res.x;
                        res.x = nHalf * 2 - 1 - tmp;
                        break;
                }

                hIndex >>= 2;
            }

            return res;
        }
    }
}
