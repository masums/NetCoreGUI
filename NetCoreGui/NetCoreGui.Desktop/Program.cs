using NetCoreGui.Controls;
using NetCoreGui.Drivers;
using System;
using System.Diagnostics;

namespace NetCoreGui.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GUI World!, Let's core, let's cross");
            var gd = new GlfwGraphicsDriver();
            Application.Init(Process.GetCurrentProcess().Handle);
            Monitor monitor = gd.GetPrimaryMonitor();

            var window = new Base.Window("WOW .Net Core", monitor, null, null);
            var form = new Base.Form() {
                Size = new Base.Size(300,200),
                Position = new Base.Rect(20,20, 280,180)
            };

            form.Add(new Button() { Text = "Click Me", Size = new Base.Size(100,50), Position = new Base.Rect(30,30, 130, 80)});
            window.Add(form);
            Application.Run(window);
        }
    }
}
