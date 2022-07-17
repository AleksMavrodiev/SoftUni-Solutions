using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private readonly List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name 
        { 
            get
            {
                return this.name;
            } 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough { get => dough; private set => dough = value; }

        public double Calories => this.Dough.Calories + toppings.Sum(x => x.Calories);
        public int NumberOfToppings => this.toppings.Count();

        public IReadOnlyCollection<Topping> Toppings
        {
            get => this.toppings.AsReadOnly();
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Calories:F2} Calories.";
        }
    }
}
