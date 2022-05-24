using System;
using System.Linq;

namespace _2._SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = input[0];
            int colsCount = input[1];
            char[,] matrix = new char[rowsCount, colsCount];
            int sameCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sameCount++;
                    }
                }
            }
            Console.WriteLine(sameCount);
        }
    }
}
