using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string type;
        private double weight;

        private readonly Dictionary<string, double> modifiers = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type 
        {
            get
            {
                return this.type;
            } 
            set
            {
                if (!modifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
            } 
        }

        public double Weight 
        { 
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
                }
                this.weight = value;
            } 
        }

        public double Calories => 2 * this.Weight * modifiers[this.type.ToLower()];
    }
}
