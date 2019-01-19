using NetCoreGui.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreGui.App
{
    public static class WindowManager
    {
        private static Dictionary<IntPtr,AppWindow> _appWindows = new Dictionary<IntPtr, AppWindow>();
       
        public static void Add(IWindow window)
        {
            _appWindows[window.NativeHandle] = new AppWindow(window);
        }

        public static IWindow Get(IntPtr nativeHandle)
        {
            if (_appWindows.ContainsKey(nativeHandle))
            {
                var appWindow = _appWindows[nativeHandle];
                return appWindow.Window;
            }
            return null;
        }
    }
}
