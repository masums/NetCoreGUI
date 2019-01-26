using Glfw3;
using NetCoreGui.App;
using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace NetCoreGui.Events
{
    public class EventManager
    {
        public static void RegisterEvents(Window window)
        {
            window.Closed += Window_Closed;
            window.KeyPressed += Window_KeyPressed;
            window.MouseMoved += Window_MouseMoved;
            window.MouseButtonReleased += Window_MouseButtonReleased;
        }

        private static void Window_MouseButtonReleased(object sender, MouseButtonEventArgs e)
        {
            WindowManager.FireMouseClick((Window)sender, e);
        }

        private static void Window_MouseMoved(object sender, MouseMoveEventArgs e)
        {
            WindowManager.FireMouseMove((Window) sender, e.X, e.Y);
        }

        private static void Window_KeyPressed(object sender, KeyEventArgs e)
        {
            WindowManager.FireKeyPresse((Window) sender, e);
        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            var window = (Window)sender;
            window.Close();
        }

        private static void OnMouseClick(Window window, MouseButtonEventArgs e)
        {
            WindowManager.FireMouseClick(window, e);
        }

        private static void OnMouseMove(Window window, double xpos, double ypos)
        {
            WindowManager.FireMouseMove(window, xpos, ypos);
        }
        
        
       private static void OnWindowRefresh(Glfw.Window w) {

            int width, heihgt;
            Glfw.GetWindowSize(w, out width, out heihgt);
            var window = WindowManager.Get(w.Ptr);

            if(window != null)
            {
                WindowManager.FireWindowRefreshed(w);
                window.GraphicsContext.ClearCanvas(Color.Transparent);
                foreach (var item in window.Chields.OrderBy(x => x.ZedIndex).ToList())
                {
                    item.Draw();
                }
            }
        }
    }
}
