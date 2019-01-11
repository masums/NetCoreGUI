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
            Application.Run(new Base.Window("WOW .Net Core", monitor, null, null));
        }
    }
}
