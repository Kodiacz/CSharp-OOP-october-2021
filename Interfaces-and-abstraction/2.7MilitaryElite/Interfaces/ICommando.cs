using System.Collections.Generic;

namespace _2._7MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }
        public void CompleteMission(string codeName);
    }
}
