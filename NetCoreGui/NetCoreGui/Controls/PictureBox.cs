using NetCoreGui.Base;
using NetCoreGui.Drawing;
using NetCoreGui.Themes;
using NetCoreGui.Utility;
using SFML.Graphics;

namespace NetCoreGui.Controls
{
    public class PictureBox : Control
    {
        public Image Image { get; set; }
        public PictureBox()
        {
            Size = Size = new Size(100, 100);            
        }        
    }

}
