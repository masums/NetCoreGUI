using NetCoreGui.Drivers;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Base
{
    public enum ControlVisibility
    {
        Visible,
        Disable,
        Hidden
    }

    public abstract class Control
    {
        public int ZedIndex { get; set; }

        public string Text { get; set; }
        public ControlVisibility Visibility { get; set; }
        public Size Size { get; set; }
        public Control Parent { get; set; }
        public List<Control> Chields { get; private set; }
        public Theme Theme { get; set; }

        public Rect Position { get; set; }
        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        public Alignment Alignment { get; set; }
        public Orientation Orientation { get; set; }
        
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
            
            return (IWindow) this;
        }

        public Control()
        {
            Chields = new List<Control>();
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

        public virtual void Draw()
        {
            var window = GetWindow();
            if(window != null)
            {
                var paint = new SKPaint() { Color = SKColors.LightGray, Style = SKPaintStyle.Fill };
                window.GraphicsContext.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, paint);
                window.GraphicsContext.DrawText(Text, Position.Left + 10, Position.Top + 20, new SKPaint() {Color=SKColors.Black, Style= SKPaintStyle.Fill });
            }
        }
    }
}
