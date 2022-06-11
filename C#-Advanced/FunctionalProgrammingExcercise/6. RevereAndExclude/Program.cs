using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._RevereAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divider = int.Parse(Console.ReadLine());
            Action<int[]> reverse = x =>
            {
                for (int i = 0; i < x.Length / 2; i++)
                {
                    int tmp = x[i];
                    x[i] = x[x.Length - i - 1];
                    x[x.Length - i - 1] = tmp;
                }
            };
            Predicate<int> divisable = x => x % divider == 0;
            reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!divisable(numbers[i]))
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
