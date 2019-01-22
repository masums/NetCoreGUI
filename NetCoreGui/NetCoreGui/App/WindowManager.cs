using Glfw3;
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

        internal static void FireMouseClick(Glfw.Window window, Glfw.MouseButton button, Glfw.InputState state, Glfw.KeyMods mods)
        {

        }

        internal static void FireMouseMove(Glfw.Window window, double xpos, double ypos)
        {
            var focusedControl = FindWindowControl(window, xpos, ypos); 
        }

        private static Control FindWindowControl(Glfw.Window window, double xpos, double ypos)
        {
            if(_appWindows.ContainsKey(window.Ptr))
            {
                var aw = _appWindows[window.Ptr];
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

        internal static void FireKeyPressed(Glfw.Window window, int scancode, Glfw.InputState state, Glfw.KeyMods mods)
        {
             
        }

        internal static void FireWindowRefreshed(Glfw.Window w)
        {
             
        }
    }
}
