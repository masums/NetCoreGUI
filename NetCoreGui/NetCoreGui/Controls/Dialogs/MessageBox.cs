using System;
using System.Collections.Generic;
using System.Text;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;

namespace NetCoreGui.Controls.Dialogs
{
    public class MessageBox : Window
    {
        public MessageBox(string title, string text, Window parent = null, Size size = null, Point position = null) : base(title, parent, size, position)
        {
            Size = new Size(100, 100);
            Position = new Point(100, 100);
        }
    }
}
