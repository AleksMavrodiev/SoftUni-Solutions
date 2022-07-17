using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private readonly List<Product> bagOfProducts;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            this.bagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProducts
        {
            get
            {
                return this.bagOfProducts.AsReadOnly();
            }
        }

        public string PurchaseProduct(Product product)
        {
            if (this.Money - product.Cost >= 0)
            {
                this.bagOfProducts.Add(product);
                this.Money -= product.Cost;
                return $"{this.Name} bought {product.Name}";
                
            }
            else
            {
                return $"{this.Name} can't afford {product.Name}";
            }
        }

        public override string ToString()
        {
            List<string> productNames = new List<string>();
            if (this.bagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            foreach (var product in this.bagOfProducts)
            {
                productNames.Add(product.Name);
            }
            return $"{this.Name} - {string.Join(", ", productNames)}";
        }
    }
}
