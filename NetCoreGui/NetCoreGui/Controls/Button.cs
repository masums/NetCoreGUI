using NetCoreGui.Base;
using NetCoreGui.Utility;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Controls
{
    public class Button : Control
    {
        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, ColorUtil.GetSfmlColor("#DED8CD"), ColorUtil.GetSfmlColor("#00A8E4"), 2);
                window.GraphicsContext.DrawText(Text, Position.Left + 10 , Position.Top + 6 );
            }   
        }
    }
}
