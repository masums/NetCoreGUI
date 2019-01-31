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

        internal Point _calclutedPosition;
        internal Size _calclutedSize;
        internal Point _position;

        #region Properties
        public string Id { get; set; }
        public int ZedIndex { get; set; }
        public bool IsFocused { get; set; }
        public string Text { get; set; }

        public ControlVisibility Visibility { get; set; }

        public Size Size { get; set; }

        public Control Parent { get; set; }
        public List<Control> Chields { get; set; }
        
        public Point Position { get => _position; set => _position = value; }

        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        public Alignment Alignment { get; set; }
        
        public Orientation Orientation { get; set; }
        
        #endregion

        #region Public Methods

        public Control(Control parent)
        {
            Chields = new List<Control>();
            Anchors = new List<Anchor>();

            Parent = parent;

            Padding = new Rect(DefaultPadding.Top, DefaultPadding.Left, DefaultPadding.Right, DefaultPadding.Bottom);
            Margin  = new Rect(DefaultMargin.Top, DefaultMargin.Left, DefaultMargin.Right, DefaultMargin.Bottom);

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
            if (_graphicsContext == null)
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
       
        public virtual void PerformLayout()
        {

        }

        //public virtual void Draw()
        //{
        //    var window = GetWindow();
        //    if (window != null)
        //    {
        //        window.Theme.DrawControl(this);                
        //    }
        //}
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

        internal void FireMouseMove(double xpos, double ypos)
        {
            OnMouseMove(this, new EventArg() { Data = new System.Drawing.Point((int)xpos, (int)ypos) });
        }

        internal void FireMouseClick(Window window, MouseButtonEventArgs e)
        {
            OnMouseClick(this, new EventArg() { Data = new { Button = e.Button, e.X, e.Y } });
        }

        internal void FireKeyDown(KeyEventArgs e)
        {
            OnKeyPresse(this, new EventArg() { Data = new { Code = e.Code, Ctrl = e.Control, Alt = e.Alt, Shift = e.Shift, System = e.System } });
        }

        internal void FireKeyUp(KeyEventArgs e)
        {
            OnKeyRelease(this, new EventArg() { Data = new { Code = e.Code, Ctrl = e.Control, Alt = e.Alt, Shift = e.Shift, System = e.System } });
        }

        #endregion
    }

    public class HiddenControl : Control{
        public HiddenControl(Control parent):base(parent)
        {
            Visibility = ControlVisibility.Hidden;
        }
    }
}
