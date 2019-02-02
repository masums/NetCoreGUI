using NetCoreGui.Base;
using NetCoreGui.Themes;
using NetCoreGui.Utility;
using SFML.Window;
using System;
using System.Diagnostics;

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
            
        }

        public override Properties AfterGetProperties(ref Properties prop, Theme theme)
        {
            prop.BackColor = BackColor.IsDefault() ? theme.TextBoxBackColor : BackColor;
            return prop;
        }
    }
}
