using _2._7MilitaryElite.Interfaces;
using System;

namespace _2._7MilitaryElite.Implemantations
{
    public class Private : Soldier, IPrivate
    {
        public Private(string iD, string firstName, string lastName, decimal salary) 
            : base(iD, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }
    }
}
