using System;
using System.Collections.Generic;

namespace _2._6FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    if (!buyers.ContainsKey(name))
                    {
                        buyers.Add(name, new Citizen(name, age, id, birthdate));
                    }
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    if (!buyers.ContainsKey(name))
                    {
                        buyers.Add(name, new Rebel(name, age, group));
                    }
                }
            }

            string command = Console.ReadLine();
            int totalFood = 0;

            while (command != "End")
            {
                if (buyers.ContainsKey(command))
                {
                    totalFood += buyers[command].BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(totalFood);
        }
    }
}
