﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Mammals
{
    using Foods;
    public class Dog : Mammal
    {
        private const double DogWeightMultiplier = 0.40;
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {

        }

        protected override IReadOnlyCollection<Type> PreferredFoods => new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => DogWeightMultiplier;

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
