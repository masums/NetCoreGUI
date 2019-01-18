using NetCoreGui.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Events
{
    public delegate void EventHandler(object sender, EventArg arg);

    public class EventArg
    {
        public dynamic Data { get; set; }
    }

    public class WindowEventArgs : EventArg
    {
        public IWindow Window { get; set; }
        public Size NewSize { get; set; }
    }
}
