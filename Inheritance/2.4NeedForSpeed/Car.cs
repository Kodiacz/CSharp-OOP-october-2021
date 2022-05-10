using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        private const double CarDefaultFuelConsumption = 3;

        public override double FuelConsumption => CarDefaultFuelConsumption;
    }
}
