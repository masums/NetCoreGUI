using NetCoreGui.Base;
using NetCoreGui.Controls;
using NetCoreGui.Drivers;
using NetCoreGui.Glfw.Controls;
using System;
using System.Diagnostics;
using System.Drawing;

namespace NetCoreGui.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GUI World!, Let's core, let's cross");
            var gd = new GraphicsDriver();
            Application.Init(Process.GetCurrentProcess().Handle);
            Monitor monitor = gd.GetPrimaryMonitor();

            var window = new Window("WOW .Net Core",null, null);
            var form = new Form() {
                Size = new Size(300,200),
                Position = new Base.Rect(20,20, 280,180)
            };

            form.Add(new Button() { Text = "Click Me", Size = new Size(100,30), Position = new Base.Rect(30,30, 130, 60)});
            form.Add(new TextBox() { Text = "Edit Text", Size = new Size(200,30), Position = new Rect(100,30, 230,230) });

            window.SetForm(form);
            Application.Run(window);
        }
    }
}
