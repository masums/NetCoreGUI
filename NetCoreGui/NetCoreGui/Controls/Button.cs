using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;
using NetCoreGui.Utility;

namespace NetCoreGui.Controls
{
    public class Button : Control
    {
        public Alignment TextAlignment { get; set; }
        public Button()
        {
            Size = Size = new Size(100, 30);            
        }        
    }
}
