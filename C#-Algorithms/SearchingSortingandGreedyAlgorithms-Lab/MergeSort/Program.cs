using System;
using System.Linq;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", MergeSort(numbers)));
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
            {
                return array;
            }

            int middleIdx = array.Length / 2;
            var lefthalf = array.Take(middleIdx).ToArray();
            var rightHalf = array.Skip(middleIdx).ToArray();

            return MergeArrays(MergeSort(lefthalf), MergeSort(rightHalf));
        }

        private static int[] MergeArrays(int[] left, int[] right)
        {
            var sorted = new int[left.Length + right.Length];
            var sortedIdx = 0;
            var leftIdx = 0;
            var rightIdx = 0;
            while (leftIdx < left.Length && rightIdx < right.Length)
            {
                if (left[leftIdx] < right[rightIdx])
                {
                    sorted[sortedIdx++] = left[leftIdx++];
                }
                else
                {
                    sorted[sortedIdx++] = right[rightIdx++];
                }
            }

            while (leftIdx < left.Length)
            {
                sorted[sortedIdx++] = left[leftIdx++];
            }

            while (rightIdx < right.Length)
            {
                sorted[sortedIdx++] = right[rightIdx++];
            }

            return sorted;
        }
    }
}
