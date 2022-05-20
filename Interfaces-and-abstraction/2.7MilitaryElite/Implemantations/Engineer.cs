using _2._7MilitaryElite.Interfaces;
using System.Collections.Generic;

namespace _2._7MilitaryElite.Implemantations
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string iD, string firstName, string lastName, decimal salary, Corps corps) 
            : base(iD, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; set; }
    }
}
