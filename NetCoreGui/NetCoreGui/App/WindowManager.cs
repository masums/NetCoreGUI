using NetCoreGui.Base;
using NetCoreGui.Events;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCoreGui.Utility
{
    public static class WindowManager
    {
        private static Dictionary<IntPtr, AppWindow> _appWindows = new Dictionary<IntPtr, AppWindow>();
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

        public static List<IWindow> GetWindows()
        {
            return _appWindows.Values.Select(x=>x.Window).ToList();
        }

        internal static void FireMouseClick(Window window, MouseButtonEventArgs e)
        {
            var ctl = FindWindowControl(window, e.X, e.Y);
            if (ctl != null)
            {
                if (_appWindows.ContainsKey(window.SystemHandle) == false)
                {
                    return;
                }

                _activeControl = ctl;
                
                var appWindw = _appWindows[window.SystemHandle];

                var ctrlId = ctl.Id;
                var windowType = appWindw.Window.GetType();
                var controllerName = windowType.Name + "Controller";
                var ctlController = windowType.Assembly.ExportedTypes.Where( x=>x.Name.Equals(controllerName)).FirstOrDefault();

                if (ctlController != null)
                {
                    var obj = Activator.CreateInstance(ctlController);
                    if(obj != null)
                    {
                        var method = ctlController.GetMethod(ctrlId + "_Clicked");
                        if (method != null)
                        {
                            method.Invoke(obj, new object[] { appWindw.Window, new MouseEventArg() { X = e.X, Y = e.Y } });
                        }
                    }
                }

                _activeControl.FireMouseClick(window, e);

            }
        }

        internal static void FireMouseReleased(Window sender, MouseButtonEventArgs e)
        {
             
        }

        internal static void FireMouseMoved(Window window, double xpos, double ypos)
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
                    var ctrl = FindControls(item, xpos, ypos);
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

        private static Control FindControls(Control control, double xpos, double ypos)
        {
            foreach (var item in control.Chields)
            {
                var ctrl = FindControls(item, xpos, ypos);
                if (ctrl != null) { return ctrl; }

                ctrl = FindControl(item, xpos, ypos);
                if (ctrl != null) { return ctrl; }
            }

            return FindControl(control, xpos, ypos);
        }

        private static Control FindControl(Control item, double xpos, double ypos)
        {
            var pos = item.GetCalclutedPosition();
            var size = item.GetCalclutedSize();

            if (Geometry.IsInsideRect(pos.x, pos.y, pos.x + size.Width, pos.y + size.Height, xpos, ypos))
            {
                return item;
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
