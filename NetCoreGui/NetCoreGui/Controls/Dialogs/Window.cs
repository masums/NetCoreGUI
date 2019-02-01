using NetCoreGui.Utility;
using NetCoreGui.Themes;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using System;
using SFML.Window;
using System.Linq;
using System.Collections.Generic;

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

        public Window(string title, Window parent = null, Point position = null)
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
            Theme = (Theme)Activator.CreateInstance(Application.ThemeType);
            _graphicsContext = _graphicsDriver.CreateWindow(Title, Size);

            NativeHandle = _graphicsContext.NativeWindowHandle; 
            Theme.GraphicsContext = _graphicsContext;
            
            WindowManager.Add(this);
            EventManager.RegisterEvents(_graphicsContext.Window);            
        } 

        public void DrawControls()
        {
            RenderControls(Chields);
        }

        private void RenderControls(List<Control> chields)
        {
            var orderdControlList = chields.OrderBy(x => x.ZedIndex).ToList();

            foreach (var item in orderdControlList)
            {
                bool isChieldsRendered = false;

                switch (item)
                {
                    case Button control:
                        Theme.DrawButton(control);
                        break;

                    case TextBox control:
                        Theme.DrawTextBox(control);
                        break;

                    case Label control:
                        Theme.DrawLabel(control);
                        break;

                    case Form control:
                        Theme.DrawForm(control);

                        break;

                    default:
                        Theme.DrawControl(item);
                        break;
                }

                if (isChieldsRendered == false && item.Chields.Count > 0)
                {
                    RenderControls(item.Chields);
                }
            }
        }
    }
}
