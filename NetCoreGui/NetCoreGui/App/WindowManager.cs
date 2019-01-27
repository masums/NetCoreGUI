using NetCoreGui.Themes;
using SFML.Window;
using System;
using System.Collections.Generic;

namespace NetCoreGui.App
{
    public static class WindowManager
    {
        private static Dictionary<IntPtr,AppWindow> _appWindows = new Dictionary<IntPtr, AppWindow>();
        private volatile static Control _activeControl = new HiddenControl();

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

        internal static void FireMouseClick(Window window, MouseButtonEventArgs e)
        {
            _activeControl.FireMouseClick(window, e);
        }

        internal static void FireMouseMove(Window window, double xpos, double ypos)
        {
            var ctl = FindWindowControl(window, xpos, ypos);
            if(ctl != null)
            {
                _activeControl = ctl;
                _activeControl.FireMouseMove(xpos, ypos);
            }
        }

        private static Control FindWindowControl(Window window, double xpos, double ypos)
        {
            if(_appWindows.ContainsKey(window.SystemHandle))
            {
                var aw = _appWindows[window.SystemHandle];
                foreach (var item in aw.Window.Chields)
                {
                    var ctrl = FindControl(item, xpos, ypos);
                    if (ctrl != null)
                    {
                        ctrl.IsFocused = true;
                        ctrl.FireMouseMove(xpos, ypos);
                        return ctrl;
                    }
                }
            }
            return null;
        }

        private static Control FindControl(Control control, double xpos, double ypos)
        {
            foreach (var item in control.Chields)
            {
                if (Geometry.IsInsideRect(item.Position.Left, item.Position.Top, item.Position.Right, item.Position.Bottom, xpos, ypos))
                {
                    return item;
                }
                var ctrl = FindControl(item, xpos, ypos);
                if(ctrl != null) { return ctrl; }
            }
            return null;
        }

        internal static void FireKeyPresse(Window window, KeyEventArgs e)
        {
            _activeControl.FireKeyDown(e);
        }

        internal static void FireWindowRefreshed(Window window)
        {
             
        }
    }
}
