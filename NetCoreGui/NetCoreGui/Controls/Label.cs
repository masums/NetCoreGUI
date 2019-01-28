using NetCoreGui.Themes;

namespace NetCoreGui.Controls
{
    public class Label : Control
    {
        public Label(Control parent) : base(parent)
        {

        }

        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawText(Text, Position.x, Position.y);
            }
        }
    }
}
