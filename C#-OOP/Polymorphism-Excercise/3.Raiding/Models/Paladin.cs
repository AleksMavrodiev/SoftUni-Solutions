using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Models
{
    public class Paladin : BaseHero
    {
        private readonly int PowerConst = 100;
        public Paladin(string name) : base(name)
        {

        }

        public override int Power => PowerConst;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
