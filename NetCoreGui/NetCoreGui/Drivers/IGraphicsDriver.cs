using NetCoreGui.Themes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace NetCoreGui.Drivers
{
    public interface IGraphicsDriver
    {
        IGraphicsContext CreateWindow(string title, Size size);
        void CloseWindow(IWindow window);
        void DrawControls(IWindow window);
    }
}
