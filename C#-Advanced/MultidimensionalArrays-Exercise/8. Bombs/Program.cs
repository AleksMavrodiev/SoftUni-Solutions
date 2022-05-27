using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                int[] coordinates = input[i].Split(",").Select(int.Parse).ToArray();
                int rowIndex = coordinates[0];
                int columnIndex = coordinates[1];
                if (matrix[rowIndex, columnIndex] > 0)
                {
                    int value = matrix[rowIndex, columnIndex];
                    matrix[rowIndex, columnIndex] = 0;
                    if (CheckIndex(rowIndex - 1, columnIndex - 1, size))
                    {
                        if (matrix[rowIndex - 1, columnIndex - 1] > 0)
                            matrix[rowIndex - 1, columnIndex - 1] -= value;
                    }
                    if (CheckIndex(rowIndex - 1, columnIndex, size))
                    {
                        if (matrix[rowIndex - 1, columnIndex] > 0)
                            matrix[rowIndex - 1, columnIndex] -= value;
                    }
                    if (CheckIndex(rowIndex - 1, columnIndex + 1, size))
                    {
                        if (matrix[rowIndex - 1, columnIndex + 1] > 0)
                            matrix[rowIndex - 1, columnIndex + 1] -= value;
                    }
                    if (CheckIndex(rowIndex, columnIndex - 1, size))
                    {
                        if (matrix[rowIndex, columnIndex - 1] > 0)
                            matrix[rowIndex , columnIndex - 1] -= value;
                    }
                    if (CheckIndex(rowIndex, columnIndex + 1, size))
                    {
                        if (matrix[rowIndex, columnIndex + 1] > 0)
                            matrix[rowIndex, columnIndex + 1] -= value;
                    }
                    if (CheckIndex(rowIndex + 1, columnIndex - 1, size))
                    {
                        if (matrix[rowIndex + 1, columnIndex - 1] > 0)
                            matrix[rowIndex + 1, columnIndex - 1] -= value;
                    }
                    if (CheckIndex(rowIndex + 1, columnIndex, size))
                    {
                        if (matrix[rowIndex + 1, columnIndex] > 0)
                            matrix[rowIndex + 1, columnIndex] -= value;
                    }
                    if (CheckIndex(rowIndex + 1, columnIndex + 1, size))
                    {
                        if (matrix[rowIndex + 1, columnIndex + 1] > 0)
                            matrix[rowIndex + 1, columnIndex + 1] -= value;
                    }
                }
                
            }
            int aliveCells = 0;
            int sum = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix, size);
        }

        static bool CheckIndex(int rowIndex, int colIndex, int size)
        {
            if (rowIndex < 0 || rowIndex >= size || colIndex < 0 || colIndex >= size)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void PrintMatrix(int[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
