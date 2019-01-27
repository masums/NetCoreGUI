using NetCoreGui.Themes;
using System;

namespace NetCoreGui.Drivers
{
    public class GraphicsDriver : IGraphicsDriver
    {
        public GraphicsDriver()
        {
            
        }

        public void CloseWindow(IWindow window)
        {
            var glfGContext = (GraphicsContext) window.GraphicsContext;
            glfGContext.CloseWindow();
        }
        public IGraphicsContext CreateWindow(string title, System.Drawing.Size size)
        {
            var mode = new SFML.Window.VideoMode((uint)size.Width, (uint)size.Height);
            var window = new SFML.Graphics.RenderWindow(mode, title);            
            window.SetFramerateLimit(10);
            //Register Events
            return new GraphicsContext(window);
        }

        public void DrawControls(IWindow window)
        {
            throw new NotImplementedException();
        }        
    }
}
