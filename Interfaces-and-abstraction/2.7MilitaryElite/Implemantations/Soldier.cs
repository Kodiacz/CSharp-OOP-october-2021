using _2._7MilitaryElite.Interfaces;

namespace _2._7MilitaryElite.Implemantations
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string iD, string firstName, string lastName)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
        }

        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
