using SFML.Graphics;
using System;

namespace NetCoreGui.Drivers
{
    public class GraphicsContext : IGraphicsContext
    {
        Font ThemeFont;
        private RenderWindow _nativeWindow;

        public GraphicsContext(RenderWindow nativeWindow)
        {
            NativeWindowHandle = nativeWindow.SystemHandle;
            _nativeWindow = nativeWindow;
            ThemeFont = new Font("Resources/Fonts/Roboto/Roboto-Regular.ttf");               
        }

        public IntPtr NativeWindowHandle { get; set; }

        public RenderWindow Window { get { return _nativeWindow; } set { _nativeWindow = value; } }

        public void ClearCanvas(Color color)
        {
            _nativeWindow.Clear(color);
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

        public void DrawRect(int left, int top, int width, int height, Color color)
        {
            var rectShape = new RectangleShape(new SFML.System.Vector2f(width, height));
            rectShape.Position = new SFML.System.Vector2f(left, top);
            rectShape.FillColor = color;
            Window.Draw(rectShape);
        }

        public void DrawText(string text, int left, int top)
        {            
            var textShapre = new Text(text, ThemeFont);
            textShapre.Position = new SFML.System.Vector2f(left, top);
            textShapre.CharacterSize = 12;
            textShapre.Color = Color.Black;
            Window.Draw(textShapre);            
        }
        
    }
}
