using NetCoreGui.Base;
using NetCoreGui.Controls;
using NetCoreGui.Controls.Dialogs;
using NetCoreGui.Drivers;
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
            //Application.Init(Process.GetCurrentProcess().Handle);
            //Monitor monitor = gd.GetPrimaryMonitor();

            var window = new Window("WOW .Net Core", null, new Rect(0, 0, 630, 630));
            var form = new Controls.Form()
            {
                Size = new Size(600, 600),
                Position = new Base.Rect(20, 20, 620, 620)
            };

            form.Add(new Button() { Id = "clickMeBtn", Text = "Click Me", Size = new Size(100,30), Position = new Base.Rect(30,30, 130, 60)});
            form.Add(new Label()  { Id = "nameLbl", Text = "Enter your name", Size = new Size(80, 20), Position = new Base.Rect(70, 20, 110, 80) });
            form.Add(new TextBox(){ Id = "inputTxt", Text = "Edit Text", Size = new Size(200,30), Position = new Rect(100,30, 230,110) });

            window.Add(form);
            Application.Run(window);
        }
    }
}
