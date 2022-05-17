using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);
            int n = queue.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    Console.Write($"{number}, ");
                }
            }
            int last = queue.Dequeue();
            if (last % 2 == 0)
            {
                Console.Write(last);
            }
        }
    }
}
