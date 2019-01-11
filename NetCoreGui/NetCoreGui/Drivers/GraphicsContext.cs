using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drivers
{
    public class GraphicsContext
    {
        public GraphicsContext(Glfw3.Glfw.Window window, SkiaSharp.SKCanvas canvas2d)
        {
            GlfwWindow = window;
            Canvas2d = canvas2d;
        }
        public Glfw3.Glfw.Window GlfwWindow { get; set; }
        public SkiaSharp.SKCanvas Canvas2d { get; set; }
    }
}
