using NetCoreGui.App;
using NetCoreGui.Themes;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using System;
using System.Drawing;

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
        public Monitor Monitor { get; set; }
        
        public Window(string title, Window parent = null, Rect position = null)
        {
            _graphicsDriver = new GraphicsDriver();

            Title = title;
            //Monitor = _graphicsDriver.GetPrimaryMonitor();
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

            NativeHandle = GraphicsContext.NativeWindowHandle; 
            
            WindowManager.Add(this);
            EventManager.RegisterEvents(GraphicsContext.Window);
        } 
    }
}
