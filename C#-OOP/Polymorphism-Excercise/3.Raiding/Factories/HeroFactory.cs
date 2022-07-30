using _3.Raiding.Factories.Contracts;
using _3.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3.Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public BaseHero CreateHero(string heroType ,string name)
        {
            BaseHero hero = null;
            if (heroType == "Druid")
            {
                hero = new Druid(name);
            }
            else if (heroType == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (heroType == "Warrior")
            {
                hero = new Warrior(name);
            }
            else if (heroType == "Rogue")
            {
                hero = new Rogue(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }
            return hero;
        }
    }
}
