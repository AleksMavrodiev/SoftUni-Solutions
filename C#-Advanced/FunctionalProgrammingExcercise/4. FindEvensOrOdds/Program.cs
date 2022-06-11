using System;
using System.Linq;

namespace _4._FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            string command = Console.ReadLine();
            Predicate<int> evenOdd = null;
            if (command == "even")
            {
                evenOdd = x => x % 2 == 0;
            }
            else
            {
                evenOdd = x => x % 2 != 0;
            }
            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (evenOdd(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
