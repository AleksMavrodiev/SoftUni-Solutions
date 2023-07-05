using System;
using System.Linq;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            QuicksortHelper(numbers, 0, numbers.Length - 1);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void QuicksortHelper(int[] numbers, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            var pivotIndex = startIndex;
            var leftIndex = startIndex + 1;
            var rightIndex = endIndex;
            while (leftIndex <= rightIndex)
            {
                if (numbers[leftIndex] > numbers[pivotIndex] && numbers[rightIndex] < numbers[pivotIndex])
                {
                    Swap(numbers, leftIndex, rightIndex);
                }

                if (numbers[leftIndex] <= numbers[pivotIndex])
                {
                    leftIndex++;
                }

                if (numbers[rightIndex] >= numbers[pivotIndex])
                {
                    rightIndex--;
                }
            }

            Swap(numbers, pivotIndex, rightIndex);
            var isLeftSubArraySmaller = rightIndex - 1 - startIndex < endIndex - (rightIndex + 1);

            if (isLeftSubArraySmaller)
            {
                QuicksortHelper(numbers, startIndex, rightIndex - 1);
                QuicksortHelper(numbers, rightIndex + 1, endIndex);
            }
            else
            {
                QuicksortHelper(numbers, rightIndex + 1, endIndex);
                QuicksortHelper(numbers, startIndex, rightIndex - 1);
            }
        }

        private static void Swap(int[] numbers, int leftIndex, int rightIndex)
        {
            var temp = numbers[leftIndex];
            numbers[leftIndex] = numbers[rightIndex];
            numbers[rightIndex] = temp;
        }
    }
}
