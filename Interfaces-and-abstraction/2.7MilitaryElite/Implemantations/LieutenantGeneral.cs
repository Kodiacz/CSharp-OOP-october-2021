using _2._7MilitaryElite.Interfaces;
using System.Collections.Generic;

namespace _2._7MilitaryElite.Implemantations
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string iD, string firstName, string lastName, decimal salary) 
            : base(iD, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }
    }
}
