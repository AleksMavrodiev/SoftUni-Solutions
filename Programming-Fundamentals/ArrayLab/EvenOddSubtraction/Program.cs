using System;
using System.Linq;

namespace EvenOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int eventSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    eventSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];
                }
            }
            Console.WriteLine(eventSum - oddSum);
        }
    }
}
