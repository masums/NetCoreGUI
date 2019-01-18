using NetCoreGui.Utility;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Drivers
{
    public class GraphicsContext : IGraphicsContext
    {
        public GraphicsContext(IntPtr windowHandle, SKCanvas canvas2d)
        {
            NativeWindowHandle = windowHandle;
            GlfwWindow = new Glfw3.Glfw.Window() { Ptr = NativeWindowHandle};
            Canvas2d = canvas2d;
        }

        public Glfw3.Glfw.Window GlfwWindow { get; set; }
        public SkiaSharp.SKCanvas Canvas2d { get; set; }
        public IntPtr NativeWindowHandle { get; set; }

        public void ClearCanvas(Color color)
        {
            var skColor = color.ToSkColor();
            Canvas2d.Clear(skColor);
        }

        public void DrawRect(int left, int top, int width, int height, SKPaint paint)
        {
            Canvas2d.DrawRect(left, top, width, height, paint);
        }

        public void DrawText(string text, int left, int top, SKPaint paint)
        {
            Canvas2d.DrawText(text, left, top, paint);
        }

        public void FlushContext()
        {
            Canvas2d.Flush();
        }
    }
}
