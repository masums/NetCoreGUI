using System;
using System.Collections.Generic;
using System.Threading;

using NetCoreGui.Drawing;
using NetCoreGui.Drivers;
using NetCoreGui.Utility;

namespace NetCoreGui.Utility
{
    public class Application
    {
        internal static IGraphicsDriver graphicsDriver;

        internal static IntPtr consoleHandle;
        internal static int _lastZedIndex = 1;

        internal static bool _isInitilized = false;        
        internal static bool _isRunning = true;

        public static List<IWindow> Windows { get; set; }
        
        public static void Init(IntPtr consoleHandle)
        {
            Application.consoleHandle = consoleHandle;
            graphicsDriver = new GraphicsDriver();
        }

        public static void Run(IWindow window){

            _lastZedIndex  = _lastZedIndex + 10000;
            window.Create(_lastZedIndex);
            var nativeWindow = window.GraphicsContext.Window;

            while (nativeWindow.IsOpen)
            {
                nativeWindow.Clear(ColorUtil.GetSfmlColor("#F5F5F5"));
                nativeWindow.DispatchEvents();
                window.DrawControls();
                nativeWindow.Display();
                Thread.Sleep(1);
            }
        }
    }
}
