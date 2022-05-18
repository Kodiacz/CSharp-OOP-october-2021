using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lasttName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LasttName = lastName;
            Age = age;
            Salary = salary;
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }

                firstName = value;
            }
        }
        public string LasttName
        {
            get
            {
                return lasttName;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }

                lasttName = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }

                age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                //if (value < 650)
                //{
                //    throw new ArgumentException("Salary cannot be less than 650 leva!");
                //}

                salary = value;
            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            percentage /= 100;

            if (Age < 30)
            {
                percentage /= 2;
            }

            Salary += Salary * percentage;
        }

        public override string ToString()
        {
            return $"{FirstName} {LasttName} receives {Salary:F2} leva.";
        }
    }
}
