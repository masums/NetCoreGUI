using NetCoreGui.Utility;
using NetCoreGui.Drawing;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using System;
using SFML.Window;

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
        
        public IGraphicsContext GraphicsContext { get; set; }
        public WindowState State { get; set; }
        
        public Window(string title, Window parent = null, Point position = null) : base(null)
        {
            _graphicsDriver = new GraphicsDriver();

            Title = title;
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
            var videoMode = VideoMode.DesktopMode;
            var y = (int) videoMode.Height / 4;
            var x = (int) videoMode.Width / 4;
            Position = new Point(x, y);
            Size = new Size(x + 400, y + 400);
        }

        internal void Show()
        {
            
        }

        public void Create(int lastZedIndex)
        {
            ZedIndex = _currentZedIndex = lastZedIndex;
            GraphicsContext = _graphicsDriver.CreateWindow(Title, Size);

            NativeHandle = GraphicsContext.NativeWindowHandle; 
            
            WindowManager.Add(this);
            EventManager.RegisterEvents(GraphicsContext.Window);
        } 

        public void DrawControls()
        {
            foreach (var item in Chields)
            {
                item.Draw();
            }
        }
    }
}
