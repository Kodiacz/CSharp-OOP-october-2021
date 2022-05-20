using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<IIdentifiable> iDs = new List<IIdentifiable>();

            while(input != "End")
            {
                string[] inputInfo = input.Split();

                if (inputInfo.Length == 3)
                {
                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string iD = inputInfo[2];

                    iDs.Add(new Citizen(name, age, iD));
                }
                else
                {
                    string model = inputInfo[0];
                    string iD = inputInfo[1];

                    iDs.Add(new Robot(model, iD));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            iDs.Where(i => i.ID.EndsWith(input))
               .Select(i => i.ID)
               .ToList()
               .ForEach(i => Console.WriteLine(i));
        }
    }
}
