using NetCoreGui.Drawing;
using NetCoreGui.Utility;
using System.Linq;

namespace NetCoreGui.Controls
{
    public class Form : Control
    {
        public bool IsActive { get; set; }

        public Form(Control parent):base(parent)
        {
            
        }

        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawRect(Position.x, Position.y, Size.Width, Size.Height, ColorUtil.GetSfmlColor("#F5F5F5"));
                
                var sortedChildrens = Chields.OrderBy(x => x.ZedIndex).ToList();
                foreach (var item in Chields)
                {
                    item.Draw();
                }
            }
        }
    }
}
