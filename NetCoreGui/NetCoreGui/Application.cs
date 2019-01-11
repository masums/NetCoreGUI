using NetCoreGui.Base;
using NetCoreGui.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreGui
{
    public class Application
    {
        internal static GlfwGraphicsDriver graphicsDriver;

        internal static IntPtr _consoleHandle;
        internal static int _lastZedIndex = 1;
        internal static bool _isInitilized = false;

        public static List<Monitor> Monitors { get; set; }
        
        public static Monitor PrimaryMonitor { get { return Monitors.Where(x => x.IsPrimary).FirstOrDefault(); } }

        internal static bool _isRunning = true;
        public static List<Window> Windows { get; set; }
        
        public static void Init(IntPtr consoleHandle)
        {
            graphicsDriver = new GlfwGraphicsDriver();
            InitilizeMonitors();
        }

        private static void InitilizeMonitors()
        {
            var monitor = graphicsDriver.GetPrimaryMonitor();
            Monitors = new List<Monitor>() { monitor };
        }

        public static void Run(Window window){

            _lastZedIndex  = _lastZedIndex + 10000;
            window.Start(_lastZedIndex);
            var nativeWindow = window.GraphicsContext.GlfwWindow;

            while (!Glfw3.Glfw.WindowShouldClose(nativeWindow))
            {
                Glfw3.Glfw.PollEvents();
                
                Glfw3.Glfw.SwapBuffers(nativeWindow);
            }
        }
    }
}
