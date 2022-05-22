using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var bus = new Bus();

            List<Vehicle> all = new List<Vehicle>();

            for (int i = 0; i < 3; i++)
            {
                string[] stats = Console.ReadLine().Split();
                double fuel = double.Parse(stats[1]);
                double fuelConsumption = double.Parse(stats[2]);
                int tankCapacity = int.Parse(stats[3]);

                if (fuelConsumption > tankCapacity)
                {
                    fuelConsumption = 0;
                }

                if (i == 0)
                {
                    all.Add(new Car(fuel, fuelConsumption, tankCapacity));
                }
                else if (i == 1)
                {
                    all.Add(new Truck(fuel, fuelConsumption, tankCapacity));
                }
                else
                {
                    all.Add(new Bus(fuel, fuelConsumption, tankCapacity));
                }
            }

            car = (Car)all[0];
            truck = (Truck)all[1];
            bus = (Bus)all[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string vehicleType = tokens[1];
                string command = tokens[0];
                double distance = double.Parse(tokens[2]);


                if (vehicleType == "Car")
                {
                    if (command == "Drive")
                    {
                        try
                        {
                            car.Drive(distance);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        try
                        {
                            car.Refuel(distance);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (vehicleType == "Truck")
                {
                    if (command == "Drive")
                    {
                        try
                        {
                            truck.Drive(distance);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        try
                        {
                            truck.Refuel(distance);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (vehicleType == "Bus")
                {
                    if (command == "Drive")
                    {
                        try
                        {
                            bus.Drive(distance);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        try
                        {
                            bus.Refuel(distance);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        try
                        {
                            bus.DriveEmpty(distance);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
