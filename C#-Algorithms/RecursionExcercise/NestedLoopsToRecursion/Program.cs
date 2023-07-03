using System;

namespace NestedLoopsToRecursion
{
    internal class Program
    {
        private static int[] numbers;

        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());
            numbers = new int[n];

            RecursiveLoops(0);
        }

        private static void RecursiveLoops(int index)
        {
            if (index >= numbers.Length)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }

            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[index] = i;
                RecursiveLoops(index + 1);
            }
        }
    }
}
