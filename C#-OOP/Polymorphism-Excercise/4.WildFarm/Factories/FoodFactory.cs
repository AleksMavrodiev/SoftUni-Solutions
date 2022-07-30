using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Factories
{
    using _4.WildFarm.Models.Foods;
    using Contracts;
    public class FoodFactory : IFoodFactory
    {
        public Food CreateFood(string type, int quantity)
        {
            Food food;
            if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else
            {
                throw new ArgumentException("Invalid food type");
            }
            return food;
        }
    }
}
