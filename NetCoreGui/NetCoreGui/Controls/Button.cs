using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;
using NetCoreGui.Utility;

namespace NetCoreGui.Controls
{
    public class Button : Control
    {
        public Button()
        {
            Size = Size = new Size(100, 30);            
        }

        public override Properties AfterGetProperties(ref Properties prop, Theme theme)
        {
            prop.ControlColor = ControlColor.IsDefault() ? theme.ButtonBackColor : ControlColor;            
            return prop;
        }
    }
}
