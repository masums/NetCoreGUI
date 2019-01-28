﻿using NetCoreGui.Themes;
using NetCoreGui.Utility;
using SFML.Window;
using System;
using System.Diagnostics;

namespace NetCoreGui.Controls
{
    public class TextBox : Control
    {
        public TextBox(Control parent) : base(parent)
        {
            OnKeyPresse += TextBox_OnKeyPresse;
        }

        private void TextBox_OnKeyPresse(object sender, Events.EventArg arg)
        {
            if(arg.Data.Code == Keyboard.Key.Backspace)
            {
                if( Text.Length > 0 )
                Text = Text.Substring(0, Text.Length - 1);
            }
            else if(arg.Data.Code == Keyboard.Key.Enter)
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

                    gcxt.DrawRect(Position.x, Position.y, Size.Width, Size.Height, new SFML.Graphics.Color(250, 250, 250), ColorUtil.GetSfmlColor("#00A8E4"), 1);
                    gcxt.DrawText(Text, Position.x + 10 , Position.y + 6 );

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
