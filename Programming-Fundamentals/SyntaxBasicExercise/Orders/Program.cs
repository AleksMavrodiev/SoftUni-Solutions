using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currentSum = 0;
            double total = 0;
            for (int i = 1; i <= n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                currentSum = price * days * count;
                Console.WriteLine($"The price for the coffee is: ${currentSum:F2}");
                total += currentSum;
                currentSum = 0;
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
