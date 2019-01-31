using System;
using System.Collections.Generic;
using System.Threading;

using NetCoreGui.Themes;
using NetCoreGui.Drivers;
using System.Diagnostics;

namespace NetCoreGui.Utility
{
    public class Application
    {
        internal IGraphicsDriver graphicsDriver;
        public static Theme Theme { get; set; }

        internal IntPtr consoleHandle;
        internal int _lastZedIndex = 1;

        internal bool _isInitilized = false;        
        internal bool _isRunning = true;

        public List<IWindow> Windows { get; set; }
        
        public static Application Create()
        {
            var app = new Application();
            app.consoleHandle = Process.GetCurrentProcess().Handle;
            app.graphicsDriver = new GraphicsDriver();
            Theme = new DefaultTheme();

            return app;
        }

        public void Run(IWindow window){

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

        public Application UseTheme(Type themeType)
        {

            return this;
        }
    }
}
