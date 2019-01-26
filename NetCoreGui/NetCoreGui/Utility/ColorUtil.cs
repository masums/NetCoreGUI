using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Utility
{
    public class ColorUtil
    {
        public static Color GetSfmlColor(string colorHex)
        {
            var conv = new System.Drawing.ColorConverter();
            System.Drawing.Color myColor = (System.Drawing.Color)conv.ConvertFromString(colorHex);
            return new Color(myColor.R, myColor.G, myColor.B, myColor.A);
        }
    }
}
