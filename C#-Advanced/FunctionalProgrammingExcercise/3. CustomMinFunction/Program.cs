using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Func<List<int>, int> findMin = list => list.Min();
            Console.WriteLine(findMin(numbers));
        }
    }
}
