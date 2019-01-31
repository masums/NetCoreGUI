using System;
using NetCoreGui.Controls;
using NetCoreGui.Drivers;
using NetCoreGui.Utility;
using SFML.Graphics;

namespace NetCoreGui.Themes
{
    public abstract class Theme
    {
        public Image AppIcon { get; set; }

        public Color BackColor { get; set; }
        public Color TextColor { get; set; }

        public Font Font { get; set; }
        public float FontSize { get; set; }
        
        public Color ControlColor { get; set; }
        public Color ControlBorderColor { get; set; }
        public Color ControlBorderHighlitedColor { get; set; }

        public Color SelectionColor { get; set; }
        public Color SelectionTextColor { get; set; }
        public Color MenuSeperatorColor { get; set; }


        public virtual void DrawTextBox(TextBox textBox)
        {
            var gcxt = textBox.GetGraphicsContext();
            gcxt.DrawRect(textBox.Position.x, textBox.Position.y, textBox.Size.Width, textBox.Size.Height, new SFML.Graphics.Color(250, 250, 250), ColorUtil.GetSfmlColor("#00A8E4"), 1);
            gcxt.DrawText(textBox.Text, textBox.Position.x + 10, textBox.Position.y + 6);
        }

        public virtual void DrawButton(Button button)
        {
            var gcxt = button.GetGraphicsContext();
            gcxt.DrawRect(button.Position.x, button.Position.y, button.Size.Width, button.Size.Height, ColorUtil.GetSfmlColor("#DED8CD"), ColorUtil.GetSfmlColor("#00A8E4"), 1);
            gcxt.DrawText(button.Text, button.Position.x + 10, button.Position.y + 6);
        }

        public virtual void DrawControl(Control control)
        {
            var gcxt = control.GetGraphicsContext();
            gcxt.DrawRect(control.Position.x, control.Position.y, control.Size.Width, control.Size.Height, ColorUtil.GetSfmlColor("#F5F5F5"), ColorUtil.GetSfmlColor("#00A8E4"), 1);
            gcxt.DrawText(control.Text, control.Position.x, control.Position.y);
        }

        internal void DrawLabel(Label control)
        {
            var gcxt = control.GetGraphicsContext();
            gcxt.DrawText(control.Text, control.Position.x, control.Position.y);
        }

        internal void DrawForm(Form control)
        {
            var gcxt = control.GetGraphicsContext();
            gcxt.DrawRect(control.Position.x, control.Position.y, control.Size.Width, control.Size.Height, ColorUtil.GetSfmlColor("#F5F5F5"));
        }
    }
}
