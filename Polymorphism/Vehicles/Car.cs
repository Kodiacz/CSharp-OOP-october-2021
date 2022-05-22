using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    internal class Car : Vehicle
    {
        private const double AirConditioningConsumption = 0.9;

        public Car()
        {
        }

        public Car(double fuel, double fuelConsumption, int tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.Fuel - (distance * (this.FuelConsumption + AirConditioningConsumption)) > 0)
            {
                Console.WriteLine($"{nameof(Car)} travelled {distance} km");
            }
            else if (this.Fuel - (distance * (this.FuelConsumption + AirConditioningConsumption)) <= 0)
            {
                throw new Exception($"{nameof(Car)} needs refueling");
            }

            this.Fuel -= distance * (this.FuelConsumption + AirConditioningConsumption);
        }

        public override void Refuel(double fuel)
        {
            if (this.Fuel + fuel > TankCapacity)
            {
                throw new Exception($"Cannot fit {fuel} fuel in the tank");
            }
            else if (fuel <= 0)
            {
                throw new Exception($"Fuel must be a positive number");
            }

            this.Fuel += fuel;
        }
    }
}
