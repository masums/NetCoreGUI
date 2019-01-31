using NetCoreGui.Themes;
using NetCoreGui.Controls;
using NetCoreGui.Controls.Dialogs;
using NetCoreGui.Drivers;
using System;
using System.Diagnostics;
using NetCoreGui.Utility;

namespace NetCoreGui.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GUI World!, Let's core, let's cross");
            var gd = new GraphicsDriver();
      
            var window = new Window( Info.LibraryName + " v" + Info.Version );
            var form = new Form(window)
            {
                Size = new Size(600, 600),
                Position = new Point(0, 0)
            };

            form.Add(new Button(form) { Id = "clickMeBtn", Text = "Click Me", Size = new Size(100,30), Position = new Point(30,30)});
            form.Add(new Label(form)  { Id = "nameLbl",    Text = "Enter your name", Size = new Size(100, 20), Position = new Point(30, 70) });
            form.Add(new TextBox(form){ Id = "inputTxt",   Text = "Edit Text", Size = new Size(200,30), Position = new Point(30,100) });

            window.Add(form);
            Application.Create().Run(window);
        }
    }
}
