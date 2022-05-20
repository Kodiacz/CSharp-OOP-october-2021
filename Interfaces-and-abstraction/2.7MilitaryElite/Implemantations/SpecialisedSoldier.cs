using _2._7MilitaryElite.Interfaces;

namespace _2._7MilitaryElite.Implemantations
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string iD, string firstName, string lastName, decimal salary, Corps corps) 
            : base(iD, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; set; }
    }
}
