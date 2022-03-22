using System;

namespace _5._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePrice(item, quantity);
        }
        static void CalculatePrice(string item, int amount)
        {
            double price = 0;
            double total = 0;
            switch (item)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            total = price * amount;
            Console.WriteLine($"{total:F2}");
        }
    }
}
