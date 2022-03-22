using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrNum = int.Parse(Console.ReadLine());
            int[] evenLeft = new int[arrNum];
            int[] evenRight = new int[arrNum];
            int counter = 0;
            for (int i = 1; i <= arrNum; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    evenRight[counter] = input[0];
                    evenLeft[counter] = input[1];
                    counter++;
                }
                else
                {
                    evenLeft[counter] = input[0];
                    evenRight[counter] = input[1];
                    counter++;
                }
            }
            Console.WriteLine(String.Join(" ", evenLeft));
            Console.WriteLine(String.Join(" ", evenRight));
        }
    }
}
