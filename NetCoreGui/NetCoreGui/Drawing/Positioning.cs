using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drawing
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

    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }
    }

    public class Rect
    {
        public Rect(int top, int left, int right, int bottom) { Top = top; Right = right; Bottom = bottom; Left = left; }

        public int Top { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
    }

    public enum Alignment
    {
        Top ,
        Left, 
        Right ,
        Bottom,
        Center,
        CenterVertical,
        CenterHorizontal,
        Fill,
        Absolute
    }

    public enum Orientation
    {
        Horizontal, 
        Vertical        
    };

    public class Anchor
    {
        public Control Neighbour { get; set; }
        public Alignment OwnPostion { get; set; }
        public Alignment NeighbourPostion { get; set; }
    }
}
