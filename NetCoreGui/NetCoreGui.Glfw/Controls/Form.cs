﻿using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{ 
    public class Form : Control, IForm
    {
        public bool IsActive { get; set; }

        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                var paint = new SKPaint() { Color = SKColors.Gray, Style = SKPaintStyle.Fill };
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, paint);

                foreach (var item in Chields)
                {
                    item.Draw();
                }
            }
        }
    }
}