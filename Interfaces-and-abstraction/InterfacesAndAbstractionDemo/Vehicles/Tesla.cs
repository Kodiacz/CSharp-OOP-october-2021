using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractionDemo.Vehicles
{
    class Tesla : Car, IElectricCar
    {
        public Tesla(string color)
            : base("S", color)
        {
        }

        public string Battery { get; set; }

        public override void Start()
        {
            Console.WriteLine("");
        }

        public override void Stop()
        {
            Console.WriteLine("");
        }
    }
}
