using System;
using System.Linq;

namespace _7.MaxSequenceOfEqulaElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int maxStreak = 1;
            int maxNumber = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int currentStreak = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentStreak++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                    maxNumber = currentNumber;
                }
            }
            for (int k = 0; k < maxStreak; k++)
            {
                Console.Write($"{maxNumber} ");
            }
        }
    }
}
