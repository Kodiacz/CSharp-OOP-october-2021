using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
            Power = 80;
        }

        public override string CastAbility()
        {
            return $"{nameof(Rogue)} - {this.Name} hit for {this.Power} damage";
        }
    }
}
