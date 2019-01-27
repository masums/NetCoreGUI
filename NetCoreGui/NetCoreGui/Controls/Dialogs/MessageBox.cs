using System;
using System.Collections.Generic;
using System.Text;
using NetCoreGui.Themes;

namespace NetCoreGui.Controls.Dialogs
{
    public class MessageBox : Window
    {
        public MessageBox(string title, Window parent = null, Rect position = null) : base(title, parent, position)
        {
        }
    }
}
