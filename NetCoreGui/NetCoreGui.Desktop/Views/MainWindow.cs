using NetCoreGui.Themes;
using NetCoreGui.Drivers;
using NetCoreGui.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using NetCoreGui.Controls.Dialogs;
using NetCoreGui.Drawing;
using NetCoreGui.Controls.Layout;
using NetCoreGui.Base;
using NetCoreGui.Controls.Container;

namespace NetCoreGui.Desktop.Views
{
    public class MainWindow : Window
    {
        public MainWindow(string title, Window parent = null, Size size = null, Point position = null) :base(title,parent,size,position)
        {
            Chields = new List<Control>() {
                new Form()
                {
                    Id = "mainForm",
                    Size = new Size(600, 600),
                    Position = new Point(0, 0),
                    Chields = new List<Control>()
                    {
                        new Button() { Id = "ClickMeBtn", Text = "Click Me", Size = new Size(100, 30), Position = new Point(30, 30) },
                        new Label() { Id = "NameLbl", Text = "Enter your name", Size = new Size(100, 20), Position = new Point(30, 70) },
                        new TextBox() { Id = "InputTxt", Text = "Edit Text", Size = new Size(200, 30), Position = new Point(30, 100) },
                        new ColumnLayout()
                        {
                            Id = "columnLayoutTest",
                            Size = new Size(300, 200),
                            Position = new Point(30, 150),
                            BackColor = Colors.Blue.L500,
                            Chields = new List<Control>() {
                                new Button(){ Id="btn2", Text = "Button 2"},
                                new Button(){ Id="btn3", Text = "Button 3"},
                                new Button(){ Id="btn4", Text = "Button 4"},
                                new Button(){ Id="btn5", Text = "Button 5"},
                                new Button(){ Id="btn6", Text = "Button 6"},
                                new Button(){ Id="btn7", Text = "Button 7"},
                                new Button(){ Id="btn8", Text = "Button 8"},
                            }
                        },
                        new RowLayout()
                        {
                            Id = "rowLayoutTest",
                            Size = new Size(550, 100),
                            Position = new Point(30, 450),
                            BackColor = Colors.Lime.L500,
                            Chields = new List<Control>() {
                                new Button(){ Id="btn2", Text = "Button 2"},
                                new Button(){ Id="btn3", Text = "Button 3"},
                                new Button(){ Id="btn4", Text = "Button 4"},
                                new Button(){ Id="btn5", Text = "Button 5"},
                                new Button(){ Id="btn6", Text = "Button 6"},
                                new Button(){ Id="btn7", Text = "Button 7"},
                                new Button(){ Id="btn8", Text = "Button 8"},
                            }
                        },
                        new GridLayout()
                        {
                            Id = "gridLayoutTest",
                            Size = new Size(450, 400),
                            Position = new Point(330, 30),
                            BackColor = Colors.Green.L500,
                            Chields = new List<Control>() {
                                new GridRow()
                                {
                                    //BackColor = Colors.Amber.L400,
                                    Chields = new List<Control>()
                                    {
                                        new GridCol()
                                        {
                                            //BackColor = Colors.Brown.L300,
                                            ColSize = GridColSize.ColEight,
                                            Chields = new List<Control>()
                                            {
                                                new Button(){ Id="btn2", Text = "Button 2"},
                                                new Button(){ Id="btn3", Text = "Button 3", Position = new Point(100,0)},
                                            }
                                        },
                                        new GridCol()
                                        {
                                            //BackColor = Colors.Brown.L300,
                                            ColSize = GridColSize.ColFour,
                                            Chields = new List<Control>()
                                            {
                                                new Button(){ Id="btn3", Text = "Button 3"},
                                            }
                                        },
                                    }
                                },
                                new GridRow()
                                {
                                    //BackColor = Colors.Amber.L300,
                                    Chields = new List<Control>()
                                    {
                                        new GridCol()
                                        {
                                            //BackColor = Colors.Brown.L200,
                                            ColSize = GridColSize.ColSix,
                                            Chields = new List<Control>()
                                            {
                                                new Button() { Id = "btn5", Text = "Button 5"},
                                                new Button() { Id = "btn6", Text = "Button 6", Position = new Point(100,0)},
                                            }
                                        },
                                        new GridCol()
                                        {
                                            //BackColor = Colors.Brown.L200,
                                            ColSize = GridColSize.ColSix,
                                            Chields = new List<Control>()
                                            {
                                                new Button() { Id = "btn7", Text = "Button 7"},
                                                new Button() { Id = "btn8", Text = "Button 8", Position = new Point(100,0)},
                                            }
                                        },
                                    }
                                },
                                new GridRow()
                                {
                                    //BackColor = Colors.Amber.L200,
                                    Chields = new List<Control>()
                                    {
                                        new GridCol()
                                        {
                                            //BackColor = Colors.Red.L200,
                                            ColSize = GridColSize.ColTwelve,
                                            Chields = new List<Control>()
                                            {
                                                new RowLayout()
                                                {
                                                    Padding = new Rect(0,0,0,0),
                                                    Margin = new Rect(0,0,0,0),
                                                    Size = new Size(450,50),
                                                    BackColor = Colors.Transparent,
                                                    Chields = new List<Control>()
                                                    {
                                                        new Button() { Id = "btn5", Text = "Button 5"},
                                                        new Button() { Id = "btn6", Text = "Button 6"},
                                                        new Button() { Id = "btn7", Text = "Button 7"},
                                                        new Button() { Id = "btn8", Text = "Button 8"},
                                                    }
                                                }
                                            }
                                        }
                                    }
                                },
                                new GridRow()
                                {
                                    //BackColor = Colors.Amber.L200,
                                    Chields = new List<Control>()
                                    {
                                        new GridCol()
                                        {
                                            ColSize = GridColSize.ColTwelve,
                                            Chields = new List<Control>()
                                            {
                                                new Panel()
                                                {
                                                    Padding = new Rect(0,0,0,0),
                                                    Margin = new Rect(0,0,0,0),
                                                    Size = new Size(440,250),
                                                    BackColor = Colors.Amber.L200,
                                                    Chields = new List<Control>()
                                                    {
                                                        new Button() { Id = "btn5", Text = "Button 5", Alignment = Alignment.TopLeft},
                                                        new Button() { Id = "btn6", Text = "Button 6", Alignment = Alignment.TopLeft},
                                                        new Button() { Id = "btn7", Text = "Button 7", Alignment = Alignment.TopRight},
                                                        new Button() { Id = "btn8", Text = "Button 8", Alignment = Alignment.BottomRight},
                                                        new Button() { Id = "btn8", Text = "Button 8", Alignment = Alignment.BottomLeft},
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
