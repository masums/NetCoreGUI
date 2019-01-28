﻿using NetCoreGui.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Utility
{
    public class AppWindow
    {
        public IWindow  Window { get; set; }    
        
        public AppWindow(IWindow window)
        {
            Window = window;
        }
    }
}
