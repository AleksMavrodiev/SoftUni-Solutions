using System;
using System.Linq;

namespace _3._MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = input[0];
            int colsCount = input[1];
            int rowIndex = 0;
            int colIndex = 0;
            int maxSum = int.MinValue;
            int currentSum = 0;
            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    currentSum += matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 2, j] + matrix[i + 1, j + 1] + matrix[i + 2, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = i;
                        colIndex = j;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine(matrix[rowIndex, colIndex] + " " + matrix[rowIndex, colIndex + 1] + " " + matrix[rowIndex, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 1, colIndex] + " " + matrix[rowIndex + 1, colIndex + 1] + " " + matrix[rowIndex + 1, colIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 2, colIndex] + " " + matrix[rowIndex + 2, colIndex + 1] + " " + matrix[rowIndex + 2, colIndex + 2]);
        }
    }
}
