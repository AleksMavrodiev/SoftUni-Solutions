using System;
using System.Linq;

namespace _1.RecursiveArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int index = 0;
            Console.WriteLine(CalculateArrSum(arr, index));
        }

        private static int CalculateArrSum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + CalculateArrSum(arr, index + 1);
        }
    }
}