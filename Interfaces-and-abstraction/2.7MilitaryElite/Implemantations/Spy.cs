using _2._7MilitaryElite.Interfaces;

namespace _2._7MilitaryElite.Implemantations
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string iD, string firstName, string lastName, int codeNumber) 
            : base(iD, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }
    }
}
