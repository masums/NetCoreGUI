using NetCoreGui.Utility;
using NetCoreGui.Themes;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using System;
using SFML.Window;
using System.Linq;
using System.Collections.Generic;
using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Controls.Layout;

namespace NetCoreGui.Controls.Dialogs
{
    public class Window : Control, IWindow
    {
        internal IGraphicsDriver _graphicsDriver;
        internal int _currentZedIndex;
        internal SFML.Graphics.RenderWindow _nativeWindow;

        public IntPtr NativeHandle { get; set; }

        public string Title { get; set; }
        public string Icon { get; set; }
        public bool IsModal { get; set; }
        
        //public IGraphicsContext GraphicsContext { get; set; }
        public WindowState State { get; set; }
        public Theme Theme { get; set; }
        public dynamic Model { get; set; }

        public Window(string title, Window parent = null, Size size = null, Point position = null)
        {
            _graphicsDriver = new GraphicsDriver();

            Title = title;
            Parent = parent;
            Position = position;
            
            if (position == null)
            {
                //SetDefaultSizeAndPosition();
                Position = new Point(0, 0);
            }

            if(size == null)
            {
                Size = new Size(800, 600);
            }

            State = WindowState.Active;
        }
        
        //private void SetDefaultSizeAndPosition()
        //{
        //    var videoMode = VideoMode.DesktopMode;
        //    var y = (int) videoMode.Height / 4;
        //    var x = (int) videoMode.Width / 4;
        //    Position = new Point(x, y);
        //    Size = new Size(x + 400, y + 400);
        //}

        public void Show()
        {
            Create(100);
        }

        public void Create(int lastZedIndex)
        {
            ZedIndex = _currentZedIndex = lastZedIndex;
            Theme = (Theme)Activator.CreateInstance(Application.ThemeType);
            _graphicsContext = _graphicsDriver.CreateWindow(Title, Size);

            NativeHandle = _graphicsContext.NativeWindowHandle; 
            Theme.GraphicsContext = _graphicsContext;
            
            WindowManager.Add(this);
            EventManager.RegisterEvents(_graphicsContext.Window);            
        } 

        public void DrawControls()
        {
            Theme.RenderControls(Chields);
        }
    }
}
