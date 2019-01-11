using Glfw3;
using NetCoreGui.Base;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drivers
{
    public interface IGraphicsDriver
    {
        Monitor GetPrimaryMonitor();
        GraphicsContext CreateWindow(string title, Size size);
        void CloseWindow(Window window);
        void DrawControls(Window window);
    }

    public class GlfwGraphicsDriver : IGraphicsDriver
    {
        public GlfwGraphicsDriver()
        {
            Glfw.Init();
            Glfw.SetErrorCallback((error, description) => Console.WriteLine("Error " + error + ": " + description));
            Glfw.WindowHint(Glfw.Hint.Visible, 1);
            Glfw.WindowHint(Glfw.Hint.Samples, 1);
            Glfw.WindowHint(Glfw.Hint.Resizable, 1);            
        }
        public void CloseWindow(Window window)
        {
            Glfw.DestroyWindow(window.GraphicsContext.GlfwWindow);
            //Glfw.Terminate();
        }

        public GraphicsContext CreateWindow(string title, Size size)
        {
            var window = Glfw.CreateWindow(size.Width, size.Height,title);
            
            Glfw.MakeContextCurrent(window);

            GRGlInterface glInterface = GRGlInterface.AssembleGlInterface(window, (contextHandle, name) =>
                {
                    var proc = Glfw.GetProcAddress(name);
                    return proc;
                }
            );

            GRContext context = GRContext.Create(GRBackend.OpenGL, glInterface);
            var brtd = new GRBackendRenderTargetDesc()
            {
                Config = GRPixelConfig.Rgba8888,
                Height = size.Height,
                Width = size.Width,
                Origin = GRSurfaceOrigin.TopLeft,
                RenderTargetHandle = new IntPtr(0),
                SampleCount = 0,
                StencilBits = 8
            };

            var backendRenderTargetDescription = new GRBackendRenderTarget(GRBackend.OpenGL, brtd);

            var surface = SKSurface.Create(context, backendRenderTargetDescription, SKColorType.Rgba8888);            
            SKCanvas _canvs2d = surface.Canvas;
            _canvs2d.Clear(SKColors.WhiteSmoke);
            _canvs2d.Flush();
            
            return new GraphicsContext(window,_canvs2d);
        }

        public void DrawControls(Window window)
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
