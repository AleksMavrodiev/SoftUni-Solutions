using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            HashSet<int> numbers2 = new HashSet<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers2.Add(number);
            }
            numbers.IntersectWith(numbers2);
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
