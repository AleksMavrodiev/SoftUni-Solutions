using System;
using System.Linq;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearchAlg(numbers, number));
        }

        private static int BinarySearchAlg(int[] numbers, int searchNumber)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left <= right)
            {
                var mid  = (left + right) / 2;
                if (numbers[mid] == searchNumber)
                {
                    return mid;
                }

                if (searchNumber > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
