using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._5BirthdayCelebrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthable> birhtdates = new List<IBirthable>();
            List<string> filterthBirthdates = new List<string>();

            while (input != "End")
            {
                string[] tokens = input.Split();
                string citizen = tokens[0];

                if (citizen == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthday = tokens[4];

                    IBirthable person = new Person(name, age, id, birthday);

                    birhtdates.Add(person);
                }
                else if (citizen == "Robot")
                {
                    string model = tokens[1];
                    string id = tokens[2];
                }
                else if (citizen == "Pet")
                {
                    string name = tokens[1];
                    string birthday = tokens[2];

                    IBirthable pet = new Pet(name, birthday);

                    birhtdates.Add(pet);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            filterthBirthdates = birhtdates.Where(b => b.Birthday.EndsWith(input))
               .Select(b => b.Birthday)
               .ToList();

            foreach (var birthdate in filterthBirthdates)
            {
                Console.WriteLine(birthdate);
            }
        }
    }
}
