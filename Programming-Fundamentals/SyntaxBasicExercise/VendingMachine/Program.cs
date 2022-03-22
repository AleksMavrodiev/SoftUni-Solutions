using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            double price = 0;
            while(command != "Start")
            {
                double input = double.Parse(command);
                if(input == 0.1 || input == 0.2 || input == 0.5 || input == 1 || input == 2)
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        price = 2;
                        if(price <= sum)
                        {
                            sum -= price;
                            Console.WriteLine("Purchased nuts");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        price = 0.7;
                        if (price <= sum)
                        {
                            sum -= price;
                            Console.WriteLine("Purchased water");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        price = 1.5;
                        if (price <= sum)
                        {
                            sum -= price;
                            Console.WriteLine("Purchased crisps");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        price = 0.8;
                        if (price <= sum)
                        {
                            sum -= price;
                            Console.WriteLine("Purchased soda");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        price = 1;
                        if (price <= sum)
                        {
                            sum -= price;
                            Console.WriteLine("Purchased coke");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
