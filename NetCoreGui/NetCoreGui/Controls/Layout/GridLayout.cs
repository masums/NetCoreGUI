using NetCoreGui.Base;
using NetCoreGui.Drawing;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Controls.Layout
{
    public class GridLayout : Control
    {
        public List<GridRow> Rows { get; set; }
        public GridLayout()
        {
            Rows = new List<GridRow>();

        }
    }

    public class GridRow
    {
        public List<GridCol> Cols { get; set; }
        public GridRow() { Cols = new List<GridCol>(); }
    }

    public class GridCol
    {
        public GridColSize Size { get; set; }
        List<Control> Controls { get; set; }
        public GridCol()
        {
            Controls = new List<Control>();
        }
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
