using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractionDemo.Shapes
{
    public class Square : IDrawable
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; }

        public void Draw()
        {
            for (int i = 0; i < this.Side; i++)
            {
                Console.WriteLine(new string('*', this.Side * 2));
            }
        }

        public void DrawShape()
        {
            Console.WriteLine(new string('*', this.Side * 2));
            for (int i = 0; i < this.Side - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', this.Side * 2 - 2) + "*");
            }

            Console.WriteLine(new string('*', this.Side * 2));
        }

        public override string ToString()
        {
            return "Square with side " + this.Side;
        }
    }
}
