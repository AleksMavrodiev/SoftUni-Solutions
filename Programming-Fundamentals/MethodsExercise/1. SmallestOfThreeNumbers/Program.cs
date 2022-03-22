using System;

namespace _1._SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            GetSmallestNum(numbers);
        }
        static void GetSmallestNum(int[] arr)
        {
            int smallestNum = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestNum)
                {
                    smallestNum = arr[i];
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
