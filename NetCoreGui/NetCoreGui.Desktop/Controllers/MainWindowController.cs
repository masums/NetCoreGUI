using NetCoreGui.Base;
using NetCoreGui.Controls.Dialogs;
using NetCoreGui.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Desktop.Controllers
{
    public class MainWindowController : Controller
    { 
        public void ClickMeBtn_Clicked(object sender, MouseEventArg arg)
        {
            new MessageBox("Test", "Test Message").Show();
        }
    }
}
