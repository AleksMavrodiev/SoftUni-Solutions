using System;
using System.Linq;

namespace _4._AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = n => n * 1.2;
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).Select(addVat).ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
