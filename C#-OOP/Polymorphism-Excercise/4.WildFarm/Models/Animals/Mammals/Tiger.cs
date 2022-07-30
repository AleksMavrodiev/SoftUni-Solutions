using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Mammals
{
    using Foods;
    public class Tiger : Feline
    {
        private const double TigerWeightMod = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override IReadOnlyCollection<Type> PreferredFoods => new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => TigerWeightMod;

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
