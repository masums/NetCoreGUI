using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Drivers
{
    public class Monitor
    {
        public string Name { get; set; }

        public int Number { get; set; }
        public bool IsPrimary { get; set; }
        public double Dpi { get; set; }
        public float ResolutionX { get; set; }
        public float ResolutionY { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
    }
}
