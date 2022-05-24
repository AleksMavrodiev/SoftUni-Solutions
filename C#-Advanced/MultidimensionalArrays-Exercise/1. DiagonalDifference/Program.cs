using System;
using System.Linq;

namespace _1._DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int primarySum = 0;
            int secondarySum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primarySum += matrix[row, col];
                    }
                    if (row + col == n - 1)
                    {
                        secondarySum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
