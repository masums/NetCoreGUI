﻿using System;
using System.Collections.Generic;
using System.Text;
using NetCoreGui.Base;
using NetCoreGui.Controls.Layout;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;

namespace NetCoreGui.Controls.Dialogs
{
    public class MessageBox : Window
    {
        public MessageBox(string title, string text, Window parent = null, Size size = null, Point position = null) : base(title, parent, size, position)
        {
            Text = title;

            Chields = new List<Control>()
            {
                new RowLayout()
                {
                    Chields = new List<Control>
                    {
                        new Label(){ Id="MessageLabel", Text = text, Size = new Size(100, 20), Position = new Point(50, 50) }
                    }
                }
            };

            Size = new Size(300, 100);
            //Position = new Point(10, 10);
        }
    }
}
