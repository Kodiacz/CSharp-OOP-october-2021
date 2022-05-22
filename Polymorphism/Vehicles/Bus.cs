using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirConditioningConsumption = 1.4;
        public Bus()
        {
        }

        public Bus(double fuel, double fuelConsumption, int tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.Fuel - (distance * (this.FuelConsumption + AirConditioningConsumption)) > 0)
            {
                Console.WriteLine($"{nameof(Bus)} travelled {distance} km");
            }
            else if (this.Fuel - (distance * (this.FuelConsumption + AirConditioningConsumption)) <= 0)
            {
                throw new Exception($"{nameof(Bus)} needs refueling");
            }

            this.Fuel -= distance * (this.FuelConsumption + AirConditioningConsumption);
        }

        public void DriveEmpty(double distance)
        {
            if (this.Fuel - (distance * this.FuelConsumption) > 0)
            {
                Console.WriteLine($"{nameof(Bus)} travelled {distance} km");
            }
            else if (this.Fuel - (distance * this.FuelConsumption) <= 0)
            {
                throw new Exception($"{nameof(Bus)} needs refueling");
            }

            this.Fuel -= distance * this.FuelConsumption;
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
