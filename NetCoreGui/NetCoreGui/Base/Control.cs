using NetCoreGui.Drivers;
using NetCoreGui.Events;
using NetCoreGui.Utility;
using SFML.Graphics;
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
        
        private List<Control> _chields;

        #region Properties
        public string Id { get; set; }
        public int ZedIndex { get; set; }
        public bool IsFocused { get; set; }
        public string Text { get; set; }

        public Color BackColor { get; set; }
        public Color ControlColor { get; set; }

        public Color BorderColor { get; set; }
        public Color TextColor { get; set; }

        public Font Font { get; set; }
        public float FontSize { get; set; }
        public Text.Styles FontStyle { get; set; }


        public ControlVisibility Visibility { get; set; }

        public Size Size { get; set; }

        public Control Parent { get; set; }

        public List<Control> Chields
        {
            get {
                foreach (var item in _chields)
                {
                    item.Parent = this;
                }
                return _chields;
            }
            set {                
                _chields = value;
            }
        }

        public Point Position { get => _position; set => _position = value; }

        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        public Alignment Alignment { get; set; }
        public Positioning Positioning { get; set; }
        public Orientation Orientation { get; set; }

        #endregion

        #region Public Methods

        public Control()
        {
            SetControlDefaults();
            
            OnMouseClick += (object sender, EventArg arg) => { };
            OnMouseDoubleClick += (object sender, EventArg arg) => { };
            OnMouseMove += (object sender, EventArg arg) => { Debug.WriteLine($"Mouse Moved on {Id}"); };

            OnKeyPresse += (object sender, EventArg arg) => { Debug.WriteLine($"Key Pressed on {Id}"); };
            OnKeyRelease += (object sender, EventArg arg) => { Debug.WriteLine($"Key Released on {Id}"); };

            OnRefresh += (object sender, EventArg arg) => { };
            OnResize += (object sender, EventArg arg) => { };
        }

        private void SetControlDefaults()
        {
            Chields = new List<Control>();
            Anchors = new List<Anchor>();

            BackColor = default(Color);
            ControlColor = default(Color);
            TextColor = default(Color);
            BorderColor = default(Color);

            Font = null;
            FontSize = 11;

            Padding = new Rect(DefaultPadding.Top, DefaultPadding.Left, DefaultPadding.Right, DefaultPadding.Bottom);
            Margin = new Rect(DefaultMargin.Top, DefaultMargin.Left, DefaultMargin.Right, DefaultMargin.Bottom);

            Alignment = Alignment.Left;
            Visibility = ControlVisibility.Visible;
            Positioning = Positioning.Relative;
        }

        public IGraphicsContext GetGraphicsContext()
        {
            if (_graphicsContext == null)
            {
                var window = GetWindow();
                _graphicsContext = window.Theme.GraphicsContext;
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

        public Point GetCalclutedPosition()
        {
            if (Parent == null || Positioning == Positioning.Absolute)
            {
                return new Point(Position.x - Margin.Left, Position.y - Margin.Top);
            }
            else
            {
                return new Point(Parent.Position.x + Position.x - Margin.Left, Parent.Position.y + Position.y - Margin.Top);
            }
        }

        public Size GetCalclutedSize()
        {
            return new Size(Size.Width - (Margin.Left + Margin.Right), Size.Height - (Margin.Top + Margin.Bottom));
        }

        public virtual Properties GetProperties(Theme theme)
        {
            var prop = new Properties();

            prop.Size = GetCalclutedSize();
            prop.Position = GetCalclutedPosition();

            prop.BackColor = BackColor.IsDefault() ? theme.BackColor : BackColor;
            prop.BorderColor = BorderColor.IsDefault() ? theme.ControlBorderColor : BorderColor;
            prop.TextColor = TextColor.IsDefault() ? theme.TextColor : TextColor;
            prop.ControlColor = ControlColor.IsDefault() ? theme.ControlColor : ControlColor;

            prop.Alignment = Alignment;
            prop.Anchors = Anchors;
            prop.Font = Font == null ? theme.Font : Font;
            prop.Margin = Margin;
            prop.Orientation = Orientation;
            prop.Padding = Padding;
            prop.Visibility = Visibility;
            prop.Positioning = Positioning;

            prop = AfterGetProperties(ref prop, theme);

            return prop;
        }

        public virtual Properties AfterGetProperties(ref Properties prop, Theme theme)
        {
            return prop;
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

    public struct Properties
    {
        public ControlVisibility Visibility { get; set; }
        public Size Size { get; set; }
        public Color BackColor { get; set; }
        public Color BorderColor { get; set; }
        public Color ControlColor { get; set; }        
        public Color TextColor { get; set; }
        public Font Font { get; set; }
        public Point Position { get; set; }

        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        public Alignment Alignment { get; set; }

        public Orientation Orientation { get; set; }
        public Positioning Positioning { get; set; }
    }

    public class HiddenControl : Control{
        public HiddenControl()
        {
            Visibility = ControlVisibility.Hidden;
        }
    }
}
