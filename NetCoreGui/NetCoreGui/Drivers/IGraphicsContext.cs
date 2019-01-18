using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using SkiaSharp;

namespace NetCoreGui.Drivers
{
    public interface IGraphicsContext
    {
        IntPtr NativeWindowHandle { get; set; }
        void ClearCanvas(Color whiteSmoke);
        void FlushContext();
        void DrawRect(int left, int top, int width, int height, SKPaint paint);
        void DrawText(string text, int v1, int v2, SKPaint sKPaint);
    }
}
