using _2._7MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace _2._7MilitaryElite.Implemantations
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string iD, string firstName, string lastName, decimal salary, Corps corps) 
            : base(iD, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName)
        {
            var mission = Missions.FirstOrDefault(m => m.CodeName == codeName);
            mission.Status = Status.Finished;
        }
    }
}
