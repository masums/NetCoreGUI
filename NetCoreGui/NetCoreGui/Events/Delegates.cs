﻿using NetCoreGui.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Events
{
    public delegate void AppEventHandler(object sender, EventArg arg);

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
