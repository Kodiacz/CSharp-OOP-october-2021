using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6FoodShortage
{
    public class Citizen : INameable, IAgeable, IIdentifiable, IBirthdateable, IBuyer
    {
        public Citizen(string name, int age, string iD, string birthdate)
        {
            Name = name;
            Age = age;
            ID = iD;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }

        public int BuyFood()
        {
            Food += 10;
            return 10;
        }
    }
}
