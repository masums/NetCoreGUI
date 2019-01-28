using NetCoreGui.Themes;
using System;

namespace NetCoreGui.Drivers
{
    public class GraphicsDriver : IGraphicsDriver
    {
        private readonly uint _frameRate;

        public GraphicsDriver(uint frameRate = 15)
        {
            _frameRate = frameRate;
        } 

        public IGraphicsContext CreateWindow(string title, Size size, SFML.Window.Styles style = SFML.Window.Styles.Default)
        {
            SFML.Window.ContextSettings contextSettings = new SFML.Window.ContextSettings(24,8,8);
            var mode = new SFML.Window.VideoMode((uint)size.Width, (uint)size.Height);
            var window = new SFML.Graphics.RenderWindow(mode, title, style);            
            window.SetFramerateLimit(_frameRate);            
            return new GraphicsContext(window);
        }

        public void DrawControls(IWindow window)
        {
            throw new NotImplementedException();
        }        
    }
}
