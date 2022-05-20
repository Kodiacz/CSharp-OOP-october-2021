using _2._5BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2._5BirthdayCelebrations
{
    public class Person : INameable, IAgeable, IIdentifiable, IBirthable
    {
        public Person(string name, int age, string iD, string birthday)
        {
            Name = name;
            Age = age;
            ID = iD;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }
        public string Birthday { get; set; }
    }
}
