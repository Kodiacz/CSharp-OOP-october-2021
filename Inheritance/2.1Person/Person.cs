using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}

// public override string ToString()
// {
//     StringBuilder stringBuilder = new StringBuilder();
//     stringBuilder.Append(String.Format(&quot; Name: { 0}, Age: { 1}
//     &quot;,
// this.Name,
// this.Age));
//     return stringBuilder.ToString();
// }