using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Base
{
    public abstract class Theme
    {
        public Color BackgroundColor { get; set; }
        public Font Font { get; set; }
        public Color ControlColor { get; set; }

    }
}
