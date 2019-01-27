using NetCoreGui.Themes;

namespace NetCoreGui.Controls
{
    public class Label : Control
    {
        public override void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawText(Text, Position.Left + 10, Position.Top);
            }
        }
    }
}
