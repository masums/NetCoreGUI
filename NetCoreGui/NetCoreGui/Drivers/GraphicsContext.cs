using NetCoreGui.Utility;
using SFML.Graphics;
using SkiaSharp;
using System;

namespace NetCoreGui.Drivers
{
    public class GraphicsContext : IGraphicsContext
    {
        Font ThemeFont;
        private RenderWindow window;

        public GraphicsContext(SFML.Graphics.RenderWindow window)
        {
            NativeWindowHandle = window.SystemHandle;
            this.window = window;
            ThemeFont = new Font("Resources/Fonts/Roboto/Roboto-Regular.ttf");               
        }

        public IntPtr NativeWindowHandle { get; set; }

        public RenderWindow Window { get { return window; } set { window = value; } }

        public void ClearCanvas(Color color)
        {
            Window.Clear(color);
        }

        internal void CloseWindow()
        {
            Window.Close();
        }

        public void DrawRect(int left, int top, int width, int height, Color color, Color outLineColor, float outLineThikness)
        {
            var rectShape = new RectangleShape(new SFML.System.Vector2f(width, height));
            rectShape.Position = new SFML.System.Vector2f(left, top);
            rectShape.FillColor = color;
            rectShape.OutlineColor = outLineColor;
            rectShape.OutlineThickness = outLineThikness;
            Window.Draw(rectShape);
        }

        public void DrawText(string text, int left, int top)
        {            
            var textShapre = new Text(text, ThemeFont);
            textShapre.Position = new SFML.System.Vector2f(left, top);
            textShapre.CharacterSize = 14;
            textShapre.Color = Color.Black;
            Window.Draw(textShapre);            
        }
        
    }
}
