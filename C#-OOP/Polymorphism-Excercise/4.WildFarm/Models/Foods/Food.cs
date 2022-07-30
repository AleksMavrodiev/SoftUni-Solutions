using System;
using System.Collections.Generic;
using System.Text;

namespace _4.WildFarm.Models.Foods
{
    public abstract class Food
    {
        public int Quantity { get; protected set; }

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
