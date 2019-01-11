using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{
    public class Size
    {
        public Size(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Rect
    {
        public Rect(int top, int left, int right, int bottom) { Top = top; Right = right; Bottom = bottom; Left = left; }

        public int Top { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
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
