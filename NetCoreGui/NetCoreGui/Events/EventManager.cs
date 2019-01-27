using NetCoreGui.App;
using SFML.Graphics;
using SFML.Window;
using System;
using System.Linq;

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
            window.Resized += Window_Resized;
        }

        private static void Window_Resized(object sender, SizeEventArgs e)
        {
            var window = (RenderWindow) sender;
            FloatRect visibleArea = new FloatRect(0, 0, e.Width, e.Height);
            window.SetView(new View(visibleArea));

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
        
    }
}
