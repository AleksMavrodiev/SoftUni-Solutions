using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> occurances = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string number = Console.ReadLine();
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 1);
                }
                else
                {
                    occurances[number]++;
                }
            }
            Console.WriteLine(occurances.First(entry => entry.Value % 2 == 0).Key);
        }
    }
}
