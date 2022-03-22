using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < input.Length / 2; i++)
            {
                string oldElement = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = oldElement;
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
