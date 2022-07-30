using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Mammals
{
    using Foods;
    public class Mouse : Mammal
    {
        private const double MouseWeigthMultiplier = 0.10;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        protected override IReadOnlyCollection<Type> PreferredFoods => new List<Type> { typeof(Vegetable), typeof(Fruit) };

        protected override double WeightMultiplier => MouseWeigthMultiplier;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
