using NetCoreGui.Base;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NetCoreGui.Controls
{ 
    public class Form : Control
    {
        public bool IsActive { get; set; }

        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {

                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, new SFML.Graphics.Color(255, 255, 255), new SFML.Graphics.Color(255, 255, 255), 1);
                
                var sortedChildrens = Chields.OrderBy(x => x.ZedIndex).ToList();
                foreach (var item in Chields)
                {
                    item.Draw();
                }
            }
        }
    }
}
