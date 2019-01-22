using Glfw3;
using NetCoreGui.App;
using NetCoreGui.Base;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Controls.Dialogs
{
    
    
    public class Window : Control, IWindow
    {
        internal IGraphicsDriver _graphicsDriver;
        internal int _currentZedIndex;

        public IntPtr NativeHandle { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsModal { get; set; }
        
        public IGraphicsContext GraphicsContext { get; set; }
        public WindowState State { get; set; }
        public Monitor Monitor { get; set; }
        
        public Window(string title, Window parent = null, Rect position = null)
        {
            _graphicsDriver = new GraphicsDriver();

            Title = title;
            Monitor = _graphicsDriver.GetPrimaryMonitor();
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

        public void Start(int lastZedIndex)
        {
            ZedIndex = _currentZedIndex = lastZedIndex;
            GraphicsContext = _graphicsDriver.CreateWindow(Title, new Size(Position.Right-Position.Left, Position.Bottom-Position.Top));

            var window = new Glfw.Window() { Ptr = GraphicsContext.NativeWindowHandle };
            NativeHandle = window.Ptr; 
            WindowManager.Add(this);
            EventManager.RegisterStandardGlfwEvents(window);
        } 
    }
}
