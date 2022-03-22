using System;
using System.Linq;

namespace _5.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < numArr.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < numArr.Length; j++)
                {
                    if (numArr[j] >= numArr[i])
                    {
                        isTopInteger = false;
                        continue;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{numArr[i]} ");
                }
            }
        }
    }
}
