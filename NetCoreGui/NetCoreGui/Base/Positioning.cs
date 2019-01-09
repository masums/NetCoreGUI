using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Rect
    {
        public Rect(float top, float left, float right, float bottom) { Top = top; Right = right; Bottom = bottom; Left = left; }

        public float Top { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }
        public float Bottom { get; set; }
    }

    public enum Position
    {
        Top ,
        Left, 
        Right ,
        Bottom
    }
    
    public class Anchor
    {
        public Control Neighbour { get; set; }
        public Position OwnPostion { get; set; }
        public Position NeighbourPostion { get; set; }
    }
}
