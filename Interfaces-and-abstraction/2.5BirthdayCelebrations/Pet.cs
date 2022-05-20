using _2._5BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5BirthdayCelebrations
{
    public class Pet : INameable, IBirthable
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
