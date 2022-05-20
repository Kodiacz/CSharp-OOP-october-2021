using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractionDemo.Vehicles
{
    public abstract class Car
    {
        public Car(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; protected set; }

        public string Color { get; protected set; }

        public virtual void Start()
        {
            Console.WriteLine("Vrum vrum...");
        }

        public abstract void Stop();
    }
}
