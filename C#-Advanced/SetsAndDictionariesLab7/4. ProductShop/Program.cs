using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] cmdArgs = input.Split(", ");
                string shop = cmdArgs[0];
                string product = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);
                AddProduct(shops, shop, product, price);
            }
            PrintPrices(shops);
        }

        static void AddProduct(Dictionary<string, Dictionary<string, double>> shops, string shop, string product, double price)
        {
            if (!shops.ContainsKey(shop))
            {
                shops.Add(shop, new Dictionary<string, double>());
            }
            shops[shop][product] = price;
        }

        static void PrintPrices(Dictionary<string, Dictionary<string, double>> shops)
        {
            foreach (var shop in shops.OrderBy(x => x.Key))
            {
                string magazin = shop.Key;
                Console.WriteLine($"{magazin}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
