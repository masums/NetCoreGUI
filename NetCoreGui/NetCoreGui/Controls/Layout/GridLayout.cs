using NetCoreGui.Base;
using NetCoreGui.Drawing;
using SFML.Graphics;
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
        public GridRow()
        {
            Padding = new Rect(0, 0, 0, 0);
            Margin = new Rect(0, 0, 0, 0);
            BackColor = Color.Transparent;
        }
    }

    public class GridCol : Control
    {
        public GridColSize ColSize { get; set; }
        public GridCol()
        {
            BackColor = Color.Transparent;
        }
    }

    public enum GridColSize : int
    {
        ColOne = 1,
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
