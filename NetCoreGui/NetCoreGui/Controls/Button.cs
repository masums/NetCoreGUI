using NetCoreGui.Themes;
using NetCoreGui.Utility;

namespace NetCoreGui.Controls
{
    public class Button : Control
    {
        public Button(Control parent) : base(parent)
        {

        }
        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawRect(Position.x, Position.y, Size.Width, Size.Height, ColorUtil.GetSfmlColor("#DED8CD"), ColorUtil.GetSfmlColor("#00A8E4"), 1);
                window.GraphicsContext.DrawText(Text, Position.x+ 10 , Position.y+ 6 );
            }   
        }
    }
}
