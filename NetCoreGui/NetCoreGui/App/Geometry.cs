using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.App
{
    public class Geometry
    {
        public static bool IsInsideRect(float x1, float y1, float x2, float y2, double pointX, double pointY)
        {
            if (pointX > x1 && pointX < x2 && pointY > y1 && pointY < y2)
                return true;
            return false;
        }
    }
}
