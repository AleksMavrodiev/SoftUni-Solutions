using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Models.Contracts
{
    public interface IHero
    {
        public string Name { get;}

        public string CastAbility();
    }
}
