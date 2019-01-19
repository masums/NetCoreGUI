using Glfw3;
using NetCoreGui.App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace NetCoreGui.Events
{
    public class EventManager
    {
        public static void RegisterStandardGlfwEvents(Glfw.Window window)
        {
            var keyPressCallBack = new Glfw.KeyFunc(OnKeyPressed);
            Glfw.SetKeyCallback(window, keyPressCallBack);

            var refreshWindowCallback = new Glfw.WindowRefreshFunc(OnWindowRefresh);
            Glfw.SetWindowRefreshCallback(window, refreshWindowCallback);

        }

        private static void OnKeyPressed(Glfw.Window window, Glfw.KeyCode key, int scancode, Glfw.InputState state, Glfw.KeyMods mods)
        {
            Debug.WriteLine(key.ToString());
        }
        
       private static void OnWindowRefresh(Glfw.Window w) {
            int width, heihgt;
            Glfw.GetWindowSize(w, out width, out heihgt);
            var window = WindowManager.Get(w.Ptr);
            if(window != null)
            {
                window.GraphicsContext.ClearCanvas(Color.WhiteSmoke);
                window.Form.Draw();
                window.GraphicsContext.FlushContext();
            }
        }
    }
}
