using System;
using System.Collections.Generic;

namespace _1.SameValueInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> numbers = new Dictionary<string, int>();
            foreach (string s in input)
            {
                if (numbers.ContainsKey(s))
                {
                    numbers[s]++;
                }
                else
                {
                    numbers.Add(s, 1);
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
