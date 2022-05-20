using InterfacesAndAbstractionDemo.Documents;
using InterfacesAndAbstractionDemo.Shapes;
using InterfacesAndAbstractionDemo.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;

namespace InterfacesAndAbstractionDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Seat("Ibiza", "Black");
            car.Start();
            car.Stop();

            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(new Circle(7));
            shapes.Add(new Square(7));
            shapes.Add(new Rectangle(10, 5));
            shapes.Add(new Square(9));
            shapes.Add(new Circle(9));
            shapes.Add(new Circle(15));
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                shape.DrawShape();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void Print(IPrintable printable)
        {
            // print header
            printable.Print();
            // print footer
        }
    }
}
