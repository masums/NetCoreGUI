using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;
using System;
using System.Collections.Generic;
using System.Text;


namespace NetCoreGui.Drivers
{
    public interface IGraphicsDriver
    {
        IGraphicsContext CreateWindow(string title, Size size, SFML.Window.Styles style = SFML.Window.Styles.Default);
        void DrawControls(IWindow window);
    }
}
