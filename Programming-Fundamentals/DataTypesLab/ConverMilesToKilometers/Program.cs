using System;

namespace ConverMilesToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.00M;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
