using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; }
        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }


    }
}
