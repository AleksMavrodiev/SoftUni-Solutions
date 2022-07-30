using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Mammals
{
    using Foods;
    public class Cat : Feline
    {
        private const double CatWeightMod = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {

        }

        protected override IReadOnlyCollection<Type> PreferredFoods => new List<Type> { typeof(Vegetable), typeof(Meat) };

        protected override double WeightMultiplier => CatWeightMod;

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
