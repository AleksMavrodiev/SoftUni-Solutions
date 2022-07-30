using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Animals.Birds
{
    using Animals;
    public abstract class Bird : Animal
    {
        public double Wingsize { get; private set; }

        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            this.Wingsize = wingSize;
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Wingsize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
