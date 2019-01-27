using NetCoreGui.Drivers;
using NetCoreGui.Events;
using NetCoreGui.Utility;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NetCoreGui.Themes
{
    public enum ControlVisibility
    {
        Visible,
        Disable,
        Hidden
    }

    public abstract class Control
    {
        internal IGraphicsContext _graphicsContext;
        internal volatile object _lock = new object();
        internal volatile bool _isDrawing = false;
        
        #region Properties
        public string Id { get; set; }
        public int ZedIndex { get; set; }
        public bool IsFocused { get; set; }
        public string Text { get; set; }
        public ControlVisibility Visibility { get; set; }
        public System.Drawing.Size Size { get; set; }
        public Control Parent { get; set; }
        public List<Control> Chields { get; set; }
        public Theme Theme { get; set; }

        public Rect Position { get; set; }
        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        public Alignment Alignment { get; set; }

        internal void FireMouseClick(Window window, MouseButtonEventArgs e)
        {
            OnMouseClick(this, new EventArg() { Data = new { Button = e.Button, e.X, e.Y} });
        }

        public Orientation Orientation { get; set; }
        #endregion

        #region Public Methods

        public Control()
        {
            Chields = new List<Control>();

            OnMouseClick += (object sender, EventArg arg) => { };
            OnMouseDoubleClick += (object sender, EventArg arg) => { };
            OnMouseMove += (object sender, EventArg arg) => { Debug.WriteLine($"Mouse Moved on {Id}"); };

            OnKeyPresse += (object sender, EventArg arg) => { Debug.WriteLine($"Key Pressed on {Id}"); };
            OnKeyRelease += (object sender, EventArg arg) => { Debug.WriteLine($"Key Released on {Id}"); };

            OnRefresh += (object sender, EventArg arg) => { };
            OnResize += (object sender, EventArg arg) => { };
        }


        public IGraphicsContext GetGraphicsContext()
        {
            if(_graphicsContext == null)
            {
                var window = GetWindow();
                _graphicsContext = window.GraphicsContext;
            }
            return _graphicsContext;
        }

        public virtual IWindow GetWindow()
        {
            IWindow window = null;
            var parent = Parent;
            while (parent != null)
            {
                if (parent is IWindow)
                {
                    window = (IWindow)parent;
                    return window;
                }
                parent = parent.Parent;
            }

            return (IWindow)this;
        }

        internal void FireMouseMove(double xpos, double ypos)
        {
            OnMouseMove(this, new EventArg() { Data = new System.Drawing.Point((int)xpos, (int)ypos) });
        }

        public virtual void Add(Control chield)
        {
            chield.Parent = this;
            Chields.Add(chield);
        }

        public virtual void Remove(Control chield)
        {
            chield.Parent = null;
            Chields.Remove(chield);
        }

        internal void FireKeyDown(KeyEventArgs e)
        {
            OnKeyPresse(this, new EventArg() { Data = new { Code = e.Code, Ctrl = e.Control, Alt = e.Alt, Shift = e.Shift, System = e.System} });
        }

        internal void FireKeyUp(KeyEventArgs e)
        {
            OnKeyRelease(this, new EventArg() { Data = new { Code = e.Code, Ctrl = e.Control, Alt = e.Alt, Shift = e.Shift, System = e.System } });
        }

        public virtual void PerformLayout()
        {

        }

        public virtual void Draw()
        {
            var window = GetWindow();
            if (window != null)
            {
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, ColorUtil.GetSfmlColor("#F5F5F5"), ColorUtil.GetSfmlColor("#00A8E4"), 1);
                window.GraphicsContext.DrawText(Text, Position.Left , Position.Top );
            }
        }
        #endregion

        #region Private Methods

        #endregion

        #region Events
        public event AppEventHandler OnMouseMove;
        public event AppEventHandler OnMouseClick;
        public event AppEventHandler OnMouseDoubleClick;

        public event AppEventHandler OnKeyPresse;
        public event AppEventHandler OnKeyRelease;

        public event AppEventHandler OnResize;
        public event AppEventHandler OnRefresh;
        #endregion
    }

    public class HiddenControl : Control{

    }
}
