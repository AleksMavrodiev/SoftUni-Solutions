using System;
using System.Linq;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ReverseArr(input, 0);
            Console.WriteLine(string.Join(" ", input));
        }

        private static void ReverseArr(int[] input, int index)
        {
            if (index == input.Length / 2)
            {
                return;
            }

            var temp = input[index];
            input[index] = input[input.Length - 1 - index];
            input[input.Length - 1 - index] = temp;
            ReverseArr(input, index + 1);
        }

    }
}
