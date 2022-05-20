using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6FoodShortage
{
    public class Rebel : INameable, IAgeable, IGroupable, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public int BuyFood()
        {
            Food += 5;
            return 5;
        }
    }
}
