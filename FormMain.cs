using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HilbertGen
{
    public partial class FormMain : Form
    {
        private Pen penLine;
        private HilbertGrid grid;

        public FormMain()
        {
            penLine = new Pen(Color.Black);
            grid = new HilbertGrid();

            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            grid.Generate((int)upDownSize.Value);

            this.Invalidate();
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int leftBorder = panelMain.Location.X + panelMain.Width;
            int width = this.ClientSize.Width - leftBorder,
                height = this.ClientSize.Height;

            int size, top, left;

            if (width > height)
            {
                size = height;
                top = 0;
                left = leftBorder + (width - size) / 2;
            }
            else
            {
                size = width;
                top = (height - size) / 2;
                left = leftBorder;
            }

            g.TranslateTransform(left, top);

            int cellsPerSide = grid.Grid.GetLength(0);

            float cellSize = (float)size / cellsPerSide;

            penLine.Width = cellSize / 5.0f;

            for (int i = 0; i < cellsPerSide; ++i)
            {
                for (int j = 0; j < cellsPerSide; ++j)
                {
                    DrawCell(g, grid.Grid[i, j], i, j, cellSize, penLine.Width);
                }
            }
        }

        private void DrawCell(Graphics g, HilbertCell cell, int i, int j, float cellSize, float lineWidth)
        {
            float posX = j * cellSize + cellSize / 2.0f,
                  posY = i * cellSize + cellSize / 2.0f;

            if ((cell & HilbertCell.Right) != HilbertCell.None)
            {
                g.DrawLine(penLine, posX - lineWidth / 2.0f, posY, posX + cellSize / 2.0f, posY);
            }

            if ((cell & HilbertCell.Left) != HilbertCell.None)
            {
                g.DrawLine(penLine, posX - cellSize / 2.0f, posY, posX + lineWidth/ 2.0f, posY);
            }

            if ((cell & HilbertCell.Top) != HilbertCell.None)
            {
                g.DrawLine(penLine, posX, posY - cellSize / 2.0f, posX, posY + lineWidth / 2.0f);
            }

            if ((cell & HilbertCell.Bottom) != HilbertCell.None)
            {
                g.DrawLine(penLine, posX, posY - lineWidth / 2.0f, posX, posY + cellSize / 2.0f);
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            panelMain.Height = this.ClientSize.Height - 24;
            this.Invalidate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            var res = dialog.ShowDialog();

            if (res != DialogResult.OK)
            {
                return;
            }

            int size = (int)upDownSize.Value;

            using StreamWriter writer = File.CreateText(dialog.FileName);

            (int x, int y)[] path = HilbertGrid.GeneratePath(size);

            foreach ((int x, int y) in path)
            {
                writer.WriteLine($"{y} {x}");
            }
        }
    }
}