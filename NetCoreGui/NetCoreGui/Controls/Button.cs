using NetCoreGui.Base;
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
                var backPaint = new SKPaint() { Color = SKColors.WhiteSmoke, Style = SKPaintStyle.Fill };
                var strokPaint = new SKPaint() { Color = SKColors.DarkGray, Style = SKPaintStyle.StrokeAndFill, StrokeWidth = 2, StrokeCap = SKStrokeCap.Square, IsStroke = true };
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, backPaint);
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, strokPaint);
                window.GraphicsContext.DrawText(Text, Position.Left + 10, Position.Top + 20, new SKPaint() { Color = SKColors.Black, Style = SKPaintStyle.Fill });
            }   
        }
    }
}
