using NetCoreGui.Base;
using NetCoreGui.Utility;
using SFML.Window;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NetCoreGui.Controls
{
    public class TextBox : Control
    {
        public TextBox()
        {
            OnKeyPresse += TextBox_OnKeyPresse;
        }

        private void TextBox_OnKeyPresse(object sender, Events.EventArg arg)
        {
            if(arg.Data.Code == Keyboard.Key.BackSpace)
            {
                Text = Text.Substring(0, Text.Length - 1);
            }
            else if(arg.Data.Code == Keyboard.Key.Return)
            {

            }
            else
            { 
                Text += arg.Data.Code;
            }
            Draw();
        }

        public override void Draw()
        {
            try
            {
                var gcxt = GetGraphicsContext();

                if (gcxt != null && _isDrawing == false)
                {
                    _isDrawing = true;

                    gcxt.DrawRect(Position.Left, Position.Top, Size.Width, Size.Height, new SFML.Graphics.Color(250, 250, 250), ColorUtil.GetSfmlColor("#00A8E4"), 2);
                    gcxt.DrawText(Text, Position.Left + 10 , Position.Top + 6 );

                    _isDrawing = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Control:Drawing:", ex.Message);
            }            
        }
    }
}
