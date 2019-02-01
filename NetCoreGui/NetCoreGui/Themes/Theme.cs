using System;
using NetCoreGui.Controls;
using NetCoreGui.Drivers;
using NetCoreGui.Utility;
using SFML.Graphics;

namespace NetCoreGui.Themes
{
    public abstract class Theme
    {
        public IGraphicsContext GraphicsContext { get; set; }
        public Image AppIcon { get; set; }

        public Color BackColor { get; set; }
        public Color TextColor { get; set; }

        public Font Font { get; set; }
        public float FontSize { get; set; }

        public int ControlBorderWidth { get; set; }
        public Color ControlColor { get; set; }
        public Color ControlBorderColor { get; set; }
        public Color ControlBorderHighlitedColor { get; set; }

        public Color SelectionColor { get; set; }
        public Color SelectionTextColor { get; set; }
        public Color MenuSeperatorColor { get; set; }

        public Color TextBoxBackColor { get; set; }
        public Color ButtonBackColor { get; set; }

        public Theme()
        {
            BackColor = ColorUtil.GetSfmlColor("#F5F5F5");
            ControlColor = ColorUtil.GetSfmlColor("#EEEEF2");
            ControlBorderColor = ColorUtil.GetSfmlColor("#00A8E4");

            TextBoxBackColor = Color.White;
            ButtonBackColor = ColorUtil.GetSfmlColor("#DED8CD");

            Font = new Font("Resources/Fonts/Roboto/Roboto-Regular.ttf");

            ControlBorderWidth = 1;
        }

        public virtual void DrawTextBox(TextBox control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, TextBoxBackColor, ControlBorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(control.Text, prop.Position.x + 10, prop.Position.y + 6);
        }

        public virtual void DrawButton(Button control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.ControlColor, prop.BorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(control.Text, prop.Position.x + 10, prop.Position.y + 6);
        }

        public virtual void DrawControl(Control control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.ControlColor, prop.BorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(control.Text, prop.Position.x, prop.Position.y);
        }

        internal void DrawLabel(Label control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawText(control.Text, prop.Position.x, prop.Position.y);
        }

        internal void DrawForm(Form control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.BackColor);
        }
    }
}
