using NetCoreGui.Drivers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{
    public enum WindowState
    {
        Active,
        Inactive,
        Minimized,
        Restored,
        Maximized
    }

    public enum WindowStartupPosition
    {
        CenterScreen,
        CenterParent,
        LastPosition
    }

    public interface IWindow
    {
        IGraphicsContext GraphicsContext { get; set; } 
        void Start(int lastZedIndex);
    }
}
