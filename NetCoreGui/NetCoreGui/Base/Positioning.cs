using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{
    public class Size
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }

    public class Rect
    {
        public float Top { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }
        public float Bottom { get; set; }

    }

    public enum Position
    {
        Top ,
        Right ,
        Bottom ,
        Left 
    }
    
    public class Anchor
    {
        public Control Neighbour { get; set; }
        public Position OwnPostion { get; set; }
        public Position NeighbourPostion { get; set; }
    }
}
