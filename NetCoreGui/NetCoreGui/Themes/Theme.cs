using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreGui.Base;
using NetCoreGui.Controls;
using NetCoreGui.Controls.Layout;
using NetCoreGui.Drawing;
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

        #region Control Drawing Functions

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
               
        public virtual void DrawLabel(Label control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawText(control.Text, prop.Position.x, prop.Position.y);
        }

        public virtual void DrawForm(Form control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.BackColor);
        }

        public virtual void DrawColumnLayout(ColumnLayout control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.BackColor);

            Dictionary<int, List<Control>> columns = new Dictionary<int, List<Control>>();
            
            int totalHeight = 0;
            int column = 1;
            
            foreach (var item in control.Chields)
            {
                totalHeight += item.Size.Height;
                
                if(totalHeight >= prop.Size.Height)
                {
                    totalHeight = item.Size.Height;
                    column++;
                }

                if(columns.Keys.Contains(column) == false)
                {
                    columns.Add(column, new List<Control>());
                }                
                columns[column].Add(item);
            }

            var colX = prop.Padding.Left;
            
            foreach (var item in columns)
            {
                var colControls = item.Value;
                var lastY = control.Padding.Top;

                foreach (var cc in colControls)
                {
                    cc.Position.x = colX;
                    cc.Position.y = lastY;
                    lastY += cc.Size.Height;
                }

                colX += colControls.Max(x => x.Size.Width);
            }

            RenderControls(control.Chields);
        }

        public virtual void DrawRowLayout(RowLayout control)
        {
            Properties prop = control.GetProperties(this);
            GraphicsContext.DrawRect(prop.Position.x, prop.Position.y, prop.Size.Width, prop.Size.Height, prop.BackColor);

            Dictionary<int, List<Control>> rows = new Dictionary<int, List<Control>>();

            int totalWidth = 0;
            int row = 1;

            foreach (var item in control.Chields)
            {
                totalWidth += item.Size.Width;

                if (totalWidth >= prop.Size.Width)
                {
                    totalWidth = item.Size.Width;
                    row++;
                }

                if (rows.Keys.Contains(row) == false)
                {
                    rows.Add(row, new List<Control>());
                }
                rows[row].Add(item);
            }

            var colY = prop.Padding.Left;

            foreach (var item in rows)
            {
                var colControls = item.Value;
                var lastX = control.Padding.Left;

                foreach (var cc in colControls)
                {
                    cc.Position.x = lastX;
                    cc.Position.y = colY;
                    lastX += cc.Size.Width;
                }

                colY += colControls.Max(x => x.Size.Height);
            }

            RenderControls(control.Chields);
        }

        #endregion

        public virtual void RenderControls(List<Control> chields)
        {
            var orderdControlList = chields.OrderBy(x => x.ZedIndex).ToList();

            foreach (var item in orderdControlList)
            {
                bool isChieldsRendered = false;

                switch (item)
                {
                    case Button control:
                        DrawButton(control);
                        break;

                    case TextBox control:
                        DrawTextBox(control);
                        break;

                    case Label control:
                        DrawLabel(control);
                        break;

                    case Form control:
                        DrawForm(control);
                        break;

                    case ColumnLayout control:
                        DrawColumnLayout(control);
                        isChieldsRendered = true;
                        break;
                    case RowLayout control:
                        DrawRowLayout(control);
                        isChieldsRendered = true;
                        break;

                    default:
                        DrawControl(item);
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
