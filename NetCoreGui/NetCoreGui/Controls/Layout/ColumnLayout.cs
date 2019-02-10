using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;
using SFML.Graphics;

namespace NetCoreGui.Controls.Layout
{
    public class ColumnLayout : Control
    {
        public ColumnLayout()
        {
            Size = new Size(200, 200);
        }

        /*
        public override Properties AfterGetProperties(ref Properties prop, Theme theme)
        {
            prop.BackColor = Color.Transparent;
            return prop;
        }
        */
    }
}
