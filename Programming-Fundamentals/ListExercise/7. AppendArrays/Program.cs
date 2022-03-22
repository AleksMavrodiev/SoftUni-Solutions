using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                string[] numbers = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
