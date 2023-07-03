using System;
using System.Linq;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSortAlg(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void BubbleSortAlg(int[] numbers)
        {
            bool isSorted = false;
            int sortedNums  = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int j = 1; j < numbers.Length - sortedNums; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        isSorted = false;
                        Swap(numbers, j - 1, j);
                    }
                }

                sortedNums++;
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
