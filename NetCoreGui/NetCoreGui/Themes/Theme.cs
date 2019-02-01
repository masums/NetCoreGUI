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

            ControlBorderWidth = 1;
        }

        public virtual void DrawTextBox(TextBox textBox)
        {
            GraphicsContext.DrawRect(textBox.Position.x, textBox.Position.y, textBox.Size.Width, textBox.Size.Height, TextBoxBackColor, ControlBorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(textBox.Text, textBox.Position.x + 10, textBox.Position.y + 6);
        }

        public virtual void DrawButton(Button button)
        {
            GraphicsContext.DrawRect(button.Position.x, button.Position.y, button.Size.Width, button.Size.Height, ButtonBackColor, ControlBorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(button.Text, button.Position.x + 10, button.Position.y + 6);
        }

        public virtual void DrawControl(Control control)
        {
            GraphicsContext.DrawRect(control.Position.x, control.Position.y, control.Size.Width, control.Size.Height, ControlColor, ControlBorderColor, ControlBorderWidth);
            GraphicsContext.DrawText(control.Text, control.Position.x, control.Position.y);
        }

        internal void DrawLabel(Label control)
        {
            GraphicsContext.DrawText(control.Text, control.Position.x, control.Position.y);
        }

        internal void DrawForm(Form control)
        {
            GraphicsContext.DrawRect(control.Position.x, control.Position.y, control.Size.Width, control.Size.Height, BackColor);
        }
    }
}
