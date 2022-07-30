using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Models
{
    public class Rogue : BaseHero
    {
        private readonly int PowerConst = 80;
        public Rogue(string name) : base(name)
        {

        }

        public override int Power => PowerConst;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
