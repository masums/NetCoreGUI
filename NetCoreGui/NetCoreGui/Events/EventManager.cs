using Glfw3;
using NetCoreGui.App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NetCoreGui.Events
{
    public class EventManager
    {
        public static void RegisterStandardGlfwEvents(Glfw.Window window)
        {
            Glfw.SetKeyCallback(window, OnKeyPressed);
            Glfw.SetWindowRefreshCallback(window, OnWindowRefresh);
            Glfw.SetCursorPosCallback(window, OnMouseMove);
            Glfw.SetMouseButtonCallback(window, OnMouseClick);
        }

        private static void OnMouseClick(Glfw.Window window, Glfw.MouseButton button, Glfw.InputState state, Glfw.KeyMods mods)
        {
            WindowManager.FireMouseClick(window, button, state, mods);
        }

        private static void OnMouseMove(Glfw.Window window, double xpos, double ypos)
        {
            WindowManager.FireMouseMove(window, xpos, ypos);
        }

        private static void OnKeyPressed(Glfw.Window window, Glfw.KeyCode key, int scancode, Glfw.InputState state, Glfw.KeyMods mods)
        {
            if(state == Glfw.InputState.Press)
            {
                Debug.WriteLine(key.ToString());
                WindowManager.FireKeyPressed(window, scancode, state, mods);
            }
        }
        
       private static void OnWindowRefresh(Glfw.Window w) {

            int width, heihgt;
            Glfw.GetWindowSize(w, out width, out heihgt);
            var window = WindowManager.Get(w.Ptr);

            if(window != null)
            {
                WindowManager.FireWindowRefreshed(w);
                window.GraphicsContext.ClearCanvas(Color.WhiteSmoke);
                foreach (var item in window.Chields.OrderBy(x => x.ZedIndex).ToList())
                {
                    item.Draw();
                }
                window.GraphicsContext.FlushContext();
            }
        }
    }
}
