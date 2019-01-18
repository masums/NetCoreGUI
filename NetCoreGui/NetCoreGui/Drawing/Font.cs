using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Base
{
    public class Font
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public float Size { get; set; }
        public Color Color { get; set; }
        public string FileName { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }

    }
}
