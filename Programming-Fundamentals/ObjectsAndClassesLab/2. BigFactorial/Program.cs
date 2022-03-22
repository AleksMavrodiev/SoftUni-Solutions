using System;
using System.Numerics;

namespace _2._BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorail = int.Parse(Console.ReadLine());
            BigInteger number = 1;
            for (int i = 2; i <= factorail; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
