﻿using NetCoreGui.Base;
using NetCoreGui.Controls;
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
            Application.Init(Process.GetCurrentProcess().Handle);
            Monitor monitor = gd.GetPrimaryMonitor();

            var window = new Window("WOW .Net Core",null, null);
            var form = new Form() {
                Size = new Size(300,200),
                Position = new Base.Rect(20,20, 280,180)
            };

            form.Add(new Button() { Text = "Click Me", Size = new Size(100,50), Position = new Base.Rect(30,30, 130, 80)});
            window.SetForm(form);
            Application.Run(window);
        }
    }
}
