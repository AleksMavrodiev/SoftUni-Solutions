using System;
using System.Linq;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSortAlg(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SelectionSortAlg(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var min = i;
                for (int curr = i + 1; curr < numbers.Length; curr++)
                {
                    if (numbers[curr] < numbers[min])
                    {
                        min = curr;
                    }
                }

                Swap(numbers, i, min);
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
