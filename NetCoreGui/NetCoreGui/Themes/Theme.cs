using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drawing
{
    public abstract class Theme
    {
        public Color BackgroundColor { get; set; }
        public Font Font { get; set; }
        public Color ControlColor { get; set; }

    }
}
