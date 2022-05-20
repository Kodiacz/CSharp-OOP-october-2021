using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        public void Draw()
        {
            DrawLine(Width, '*', '*');

            for (int i = 1; i < Height - 1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }

            DrawLine(Width, '*', '*');
        }

        public void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }

            Console.WriteLine(end);
        }
    }
}
