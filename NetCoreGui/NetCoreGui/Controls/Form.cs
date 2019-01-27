﻿using NetCoreGui.Themes;
using NetCoreGui.Utility;
using System.Linq;

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

                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, ColorUtil.GetSfmlColor("#F5F5F5"));
                
                var sortedChildrens = Chields.OrderBy(x => x.ZedIndex).ToList();
                foreach (var item in Chields)
                {
                    item.Draw();
                }
            }
        }
    }
}
