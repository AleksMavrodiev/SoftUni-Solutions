using System;
using System.Linq;

namespace _8._ListOFPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Predicate<int> divisible = null;
            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = true;
                for (int j = 0; j < numbers.Length; j++)
                {
                    int divider = numbers[j];
                    divisible = x => x % divider == 0;
                    if (!divisible(i))
                    {
                        isDivisible = false;
                    }
                }
                if (isDivisible)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
