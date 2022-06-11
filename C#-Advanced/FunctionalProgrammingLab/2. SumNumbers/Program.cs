using System;
using System.Linq;

namespace _2._SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = input.Split(", ").Select(parser).ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
