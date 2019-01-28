using System;
using System.Collections.Generic;
using System.Text;
using NetCoreGui.Drawing;

namespace NetCoreGui.Controls.Dialogs
{
    public class MessageBox : Window
    {
        public MessageBox(string title, Window parent = null, Point position = null) : base(title, parent, position)
        {
        }
    }
}
