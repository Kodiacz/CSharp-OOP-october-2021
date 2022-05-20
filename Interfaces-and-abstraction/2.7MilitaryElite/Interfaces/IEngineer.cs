using System.Collections.Generic;

namespace _2._7MilitaryElite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}
