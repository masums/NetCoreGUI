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
        TopLeft ,
        TopCenter,
        TopRight,
        CenterLeft,
        Center,
        CenterRight,
        BottomLeft,
        BottomCenter,
        BottomRight       
    }

    public enum Positioning
    {
        Relative,
        Fixed,
        Absolute,
        FillParent,
    }

    public enum Orientation
    {
        Horizontal, 
        Vertical        
    };

    public enum Anchor
    {
        Top ,
        Left, 
        Right ,
        Bottom,
        All
    }

    public struct DefaultPadding
    {
        public static int Top = 3;
        public static int Left = 3;
        public static int Right = 3;
        public static int Bottom = 3;
    }

    public struct DefaultMargin
    {
        public static int Top = 3;
        public static int Left = 3;
        public static int Right = 3;
        public static int Bottom = 3;
    }
}
