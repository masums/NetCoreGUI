using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Utility
{
    public static class SkiaUtil
    {
        public static SKColor ToSkColor(this System.Drawing.Color color)
        {
            var skColor = new SKColor(color.R, color.G, color.B, color.A);
            return skColor;
        }
    }
}
