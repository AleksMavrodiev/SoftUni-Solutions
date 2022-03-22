using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double total = 0;
            switch (type)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 10.46;
                    }
                    total = price * count;
                    if (count >= 30)
                    {
                        total *= 0.85;
                    }
                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 16;
                    }
                    total = price * count;
                    if (count >= 100)
                    {
                        total -= 10 * price;
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        price = 22.50;
                    }
                    total = price * count;
                    if (count >= 10 && count <= 20)
                    {
                        total *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}
