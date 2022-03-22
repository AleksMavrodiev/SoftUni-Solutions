using System;
using System.Collections.Generic;

namespace _4._Orders
{

    class Item
    {
        public Item(int quantity, double price)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary <string, Item> productQuantity = new Dictionary<string, Item>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string productName = cmdArgs[0];
                double productPrice = double.Parse(cmdArgs[1]);
                int quantity = int.Parse(cmdArgs[2]);
                if (productQuantity.ContainsKey(productName))
                {
                    productQuantity[productName].Quantity += quantity;
                    if (productQuantity[productName].Price != productPrice)
                    {
                        productQuantity[productName].Price = productPrice;
                    }
                }
                else
                {
                    productQuantity.Add(productName, new Item(quantity, productPrice));
                }
              
            }
            foreach (var item in productQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Quantity * item.Value.Price:F2}");
            }
        }
    }
}
