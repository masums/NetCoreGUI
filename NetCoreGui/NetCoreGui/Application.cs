﻿using Glfw3;
using NetCoreGui.Base;
using NetCoreGui.Drivers;
using NetCoreGui.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NetCoreGui
{
    public class Application
    {
        internal static IGraphicsDriver graphicsDriver;

        internal static IntPtr _consoleHandle;
        internal static int _lastZedIndex = 1;
        internal static bool _isInitilized = false;

        public static List<Monitor> Monitors { get; set; }
        
        public static Monitor PrimaryMonitor { get { return Monitors.Where(x => x.IsPrimary).FirstOrDefault(); } }

        internal static bool _isRunning = true;
        public static List<IWindow> Windows { get; set; }
        
        public static void Init(IntPtr consoleHandle)
        {
            graphicsDriver = new GraphicsDriver();
            InitilizeMonitors();            
        }

        private static void InitilizeMonitors()
        {
            var monitor = graphicsDriver.GetPrimaryMonitor();
            Monitors = new List<Monitor>() { monitor };
        }

        public static void Run(IWindow window){

            _lastZedIndex  = _lastZedIndex + 10000;
            window.Start(_lastZedIndex);

            var nativeWindow = new Glfw.Window() { Ptr = window.GraphicsContext.NativeWindowHandle };
            
            while (!Glfw.WindowShouldClose(nativeWindow))
            {
                Glfw.PollEvents();                
                Glfw.SwapBuffers(nativeWindow);                
            }
        } 
    }
}
