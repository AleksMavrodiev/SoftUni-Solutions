using System;
using System.Linq;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            InsertionSortAlg(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void InsertionSortAlg(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                var j = i;
                while (j > 0 && numbers[j] < numbers[j - 1])
                {
                    Swap(numbers, j, j - 1);
                    j--;
                }

            }
        }

        private static void Swap(int[] numbers, int i, int min)
        {
            var temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
        }
    }
}
