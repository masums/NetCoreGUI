using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Themes
{
    public abstract class Theme
    {
        public Color BackColor { get; set; }
        public Color TextColor { get; set; }

        public Font Font { get; set; }
        public float FontSize { get; set; }

        public Color ControlColor { get; set; }
        public Color ControlBorderColor { get; set; }
        public Color ControlBorderHighlitedColor { get; set; }

        public Color MenuColor { get; set; }
        public Color MenuItemColor { get; set; }
        public Color MenuSeperatorColor { get; set; }

    }
}
