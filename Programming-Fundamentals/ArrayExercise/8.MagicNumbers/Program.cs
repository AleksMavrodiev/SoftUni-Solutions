using System;
using System.Linq;

namespace _8.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            int[] magicPair = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int[] testArray = {arr[i], arr[j] };
                    if (arr[i] + arr[j] == magicNumber && (!magicPair.Contains(testArray[0]) || !magicPair.Contains(testArray[1])))
                    {
                        magicPair[i] = testArray[0];
                        magicPair[j] = testArray[1];
                        Console.WriteLine(String.Join(' ', testArray));
                    }
                }
            }
        }
    }
}
