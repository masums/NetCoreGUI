using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NetCoreGui.Platforms
{
    public class Windows
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]

        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public struct WindowState
        {
            public const int Hide = 0;
            public const int Show = 5;
        }
    }
}
