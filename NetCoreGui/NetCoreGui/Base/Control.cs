using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Base
{
    public abstract class Control
    {
        public Control Parent { get; set; }
        public List<Control> Chields { get; set; }
        public Theme Theme { get; set; }

        public Rect Position { get; set; }
        public Size Size { get; set; }
        public List<Anchor> Anchors { get; set; }
        public Rect Padding { get; set; }
        public Rect Margin { get; set; }
        
        public void PerformLayout()
        {

        }

        public void Draw()
        {

        }
    }
}
