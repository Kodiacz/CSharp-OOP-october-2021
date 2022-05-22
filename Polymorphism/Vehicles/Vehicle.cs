using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle : IDriveable
    {
        protected Vehicle()
        {

        }

        protected Vehicle(double fuel, double fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }

        protected Vehicle(double fuel, double fuelConsumption, int tankCapacity)
        {
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public int TankCapacity { get; set; }

        public abstract void Drive(double distance);

        public abstract void Refuel(double fuel);
    }
}
