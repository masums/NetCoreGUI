using NetCoreGui.Base;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreGui.Glfw.Controls
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

                var sortedChildrens = Chields.OrderBy(x => x.ZedIndex).ToList();
                foreach (var item in Chields)
                {
                    item.Draw();
                }
            }
        }
    }
}
