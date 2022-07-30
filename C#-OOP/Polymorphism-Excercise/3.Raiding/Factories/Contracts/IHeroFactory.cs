using _3.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Factories.Contracts
{
    public interface IHeroFactory
    {
        BaseHero CreateHero(string heroType ,string name);
    }
}
