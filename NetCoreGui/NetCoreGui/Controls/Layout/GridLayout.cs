using NetCoreGui.Base;
using NetCoreGui.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Controls.Layout
{
    public class GridLayout : Control
    {
        
    }

    public class GridRow : Control
    {

    }

    public class GridCol : Control
    {
        public GridColSize ColSize { get; set; }
    }

    public enum GridColSize
    {
        ColOne,
        ColTwo,
        ColThree,
        ColFour,
        ColFive,
        ColSix,
        ColSeven,
        ColEight,
        ColNine,
        ColTen,
        ColEleven,
        ColTwelve
    }
}
