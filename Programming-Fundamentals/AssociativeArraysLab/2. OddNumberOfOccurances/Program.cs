using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._OddNumberOfOccurances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary <string, int> counts = new Dictionary<string, int>();
            foreach (string line in input)
            {
                if (counts.ContainsKey(line.ToLower()))
                {
                    counts[line.ToLower()]++;
                }
                else
                {
                    counts.Add(line.ToLower(), 1);
                }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
