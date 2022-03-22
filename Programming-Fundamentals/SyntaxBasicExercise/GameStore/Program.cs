using System;

namespace GameStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double Total = money;
            string command = Console.ReadLine();
            double price;
            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4":
                        price = 39.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "CS: OG":
                        price = 15.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought CS: OG");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        price = 59.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought Honored 2");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        if (money >= price)
                        {
                            money -= price;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${Total - money:F2}. Remaining: ${money:F2}");
            }
        }
    }
}
