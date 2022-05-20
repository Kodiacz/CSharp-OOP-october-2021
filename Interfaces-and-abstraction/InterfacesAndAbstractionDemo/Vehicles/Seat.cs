using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractionDemo.Vehicles
{
    public class Seat : Car
    {
        public Seat(string model, string color)
            : base(model, color)
        {
        }

        public override void Stop()
        {
            Console.WriteLine("eeeeeee");
        }
    }
}
