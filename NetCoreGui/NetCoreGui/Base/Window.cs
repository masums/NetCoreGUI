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

        public string Title { get; set; }
        public string Icon { get; set; }
        public int CurrentZedIndex { get; set; }
        public IntPtr WindowHandle { get; set; }
        public IntPtr GraphicsContext { get; set; }

        public WindowState State { get; set; }
        public Monitor Monitor { get; set; }
        
        public Window(string title, Monitor monitor, Window parent = null, Rect position = null)
        {
            _graphicsDriver = new GlfwGraphicsDriver();
            Title = title;
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
            var y = (int) Monitor.ResolutionY / 4;
            var x = (int) Monitor.ResolutionX / 4;
            Position = new Rect(x, y, x + 400, y + 400);
        }

        internal void Show()
        {
            
        }

        internal void Start(int lastZedIndex)
        {
            ZedIndex = CurrentZedIndex = lastZedIndex;
            WindowHandle = _graphicsDriver.CreateWindow(Title, new Size(Position.Right-Position.Left, Position.Bottom-Position.Top));
        }

        public Glfw3.Glfw.Window GetGlfwWindow()
        {
            return new Glfw3.Glfw.Window() { Ptr = WindowHandle};
        }
    }
}
