using System;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(x => x).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (i >= numbers.Length)
                {
                    break;
                }
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
