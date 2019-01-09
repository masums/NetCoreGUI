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
    
    public class Window : Control
    {
        internal GlfwGraphicsDriver _graphicsDriver;

        public int CurrentZedIndex { get; set; }
        public IntPtr WindowHandle { get; set; }
        public IntPtr GraphicsContext { get; set; }

        public WindowState State { get; set; }
        public Monitor Monitor { get; set; }
        
        public Window(Monitor monitor, Window parent = null, Rect position = null)
        {
            _graphicsDriver = new GlfwGraphicsDriver();

            Monitor = monitor;
            Parent = parent;
            Position = position;
            
            if (position == null)
            {
                SetDefaultSizeAndPosition();   
            }

            State = WindowState.Active;
        }

        private void SetDefaultSizeAndPosition()
        {
            var y = Monitor.ResolutionY / 4;
            var x = Monitor.ResolutionX / 4;
            Position = new Rect(x, y, x + 400, y + 400);
        }

        internal void Show()
        {
            
        }

        internal void Start(int lastZedIndex)
        {
            ZedIndex = CurrentZedIndex = lastZedIndex;

        }
    }
}
