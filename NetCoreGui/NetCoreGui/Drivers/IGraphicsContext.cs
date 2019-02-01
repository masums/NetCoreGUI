using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drivers
{
    public interface IGraphicsContext
    {
        RenderWindow Window { get; set; }
        IntPtr NativeWindowHandle { get; set; }
        void ClearCanvas(Color whiteSmoke);
        
        void DrawRect(int left, int top, int width, int height, Color color, Color outLineColor, float outLineThikness);
        void DrawRect(int left, int top, int width, int height, Color color);
        void DrawText(string text, int left, int top);        
    }
}
