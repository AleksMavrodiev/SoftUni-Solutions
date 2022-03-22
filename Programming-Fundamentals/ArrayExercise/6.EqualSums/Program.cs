using System;
using System.Linq;

namespace _6.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            
            bool isEqual = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                leftSum += arr[i];
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] == leftSum)
                    {
                        isEqual = true;
                        Console.WriteLine(i + 1);
                        break;
                    }
                    rightSum += arr[j];
                    if (rightSum == leftSum)
                    {
                        Console.WriteLine(i + 1);
                        isEqual = true;
                        break;
                    }
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
