using NetCoreGui.Themes;
using NetCoreGui.Controls;
using NetCoreGui.Controls.Dialogs;
using NetCoreGui.Drivers;
using System;
using System.Diagnostics;
using NetCoreGui.Utility;
using System.Collections.Generic;
using SFML.Graphics;
using NetCoreGui.Drawing;
using NetCoreGui.Base;
using NetCoreGui.Controls.Layout;

namespace NetCoreGui.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GUI World!, Let's core, let's cross");
            var gd = new GraphicsDriver();
      
            var window = new Window( Info.LibraryName + " v" + Info.Version );
            var form = new Form()
            {
                Id="mainForm",
                Size = new Size(600, 600),
                Position = new Point(0, 0)                
            };

            form.Add(new Button() { Id = "clickMeBtn", Text = "Click Me", Size = new Size(100,30), Position = new Point(30,30)});
            form.Add(new Label()  { Id = "nameLbl",    Text = "Enter your name", Size = new Size(100, 20), Position = new Point(30, 70) });
            form.Add(new TextBox(){ Id = "inputTxt",   Text = "Edit Text", Size = new Size(200,30), Position = new Point(30,100) });
            
            form.Add(new ColumnLayout() {
                Id = "columnLayoutTest",
                Size = new Size(300,200),
                Position = new Point(30,150),
                BackColor = Color.Blue,
                Chields = new List<Control>() {
                    new Button(){ Id="btn2", Position = new Point(10,10), Text = "Button 2"},
                    new Button(){ Id="btn3", Position = new Point(10,10), Text = "Button 3"},
                    new Button(){ Id="btn4", Position = new Point(10,10), Text = "Button 4"},
                    new Button(){ Id="btn5", Position = new Point(10,10), Text = "Button 5"},
                    new Button(){ Id="btn6", Position = new Point(10,10), Text = "Button 6"},
                    new Button(){ Id="btn7", Position = new Point(10,10), Text = "Button 7"},
                    new Button(){ Id="btn8", Position = new Point(10,10), Text = "Button 8"}, 
                }
            });

            form.Add(new RowLayout()
            {
                Id = "rowLayoutTest",
                Size = new Size(550, 100),
                Position = new Point(30, 350),
                BackColor = Color.Magenta,
                Chields = new List<Control>() {
                    new Button(){ Id="btn2", Position = new Point(10,10), Text = "Button 2"},
                    new Button(){ Id="btn3", Position = new Point(10,10), Text = "Button 3"},
                    new Button(){ Id="btn4", Position = new Point(10,10), Text = "Button 4"},
                    new Button(){ Id="btn5", Position = new Point(10,10), Text = "Button 5"},
                    new Button(){ Id="btn6", Position = new Point(10,10), Text = "Button 6"},
                    new Button(){ Id="btn7", Position = new Point(10,10), Text = "Button 7"},
                    new Button(){ Id="btn8", Position = new Point(10,10), Text = "Button 8"},
                }
            });

            window.Add(form);
            Application.Create().Run(window);
        }
    }
}
