using Glfw3;
using NetCoreGui.Base;
using NetCoreGui.Utility;
using SFML.Graphics;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

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

        public Monitor GetPrimaryMonitor()
        {
            Glfw.Monitor primaryMonitor = Glfw.GetPrimaryMonitor();
            var monitorName = Glfw.GetMonitorName(primaryMonitor);

            int widthMm, heightMm;
            Glfw.GetMonitorPhysicalSize(primaryMonitor, out widthMm, out heightMm);
            Glfw.VideoMode mode = Glfw.GetVideoMode(primaryMonitor);

            double dpi;
            dpi = mode.Width / (widthMm / 25.4);
            
            var monitor = new Monitor()
            {
                Name = monitorName,
                IsPrimary = true,
                Number = 1,
                Dpi = dpi,
                ResolutionX = mode.Width,
                ResolutionY = mode.Height
            };
            return monitor;
        }
        
    }
}
