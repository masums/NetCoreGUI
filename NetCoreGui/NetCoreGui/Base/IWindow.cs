using NetCoreGui.Drivers;
using NetCoreGui.Themes;
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
        IntPtr NativeHandle { get; set; }

        Theme Theme { get; set; }
        string Title { get; set; }
        string Icon { get; set; }
        bool IsModal { get; set; }
        
        WindowState State { get; set; }
             
        //IGraphicsContext GraphicsContext { get; set; }

        List<Control> Chields { get; set; }

        void Create(int lastZedIndex);
        void DrawControls();
        void Close();
    }
}
