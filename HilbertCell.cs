using System;

namespace HilbertGen
{
    [Flags]
    public enum HilbertCell : byte
    {
        None = 0, 
        Top = 1, 
        Left = 2, 
        Right = 4, 
        Bottom = 8
    }
}
