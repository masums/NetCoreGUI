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
using NetCoreGui.Desktop.Views;

namespace NetCoreGui.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GUI World!, Let's core, let's cross");
           
            var window = new MainWindow( Info.LibraryName + " v" + Info.Version );           
            Application.ProstutHou().Bismillah(window);
        }           
    }
}
