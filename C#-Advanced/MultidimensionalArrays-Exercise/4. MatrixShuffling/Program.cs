using System;
using System.Linq;

namespace _4._MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = input[0];
            int colsCount = input[1];
            string[,] matrix = new string[rowsCount, colsCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string action = string.Empty;
                int row1, col1, row2, col2;
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command.StartsWith("swap") && cmdArgs.Length == 5)
                {
                    action = cmdArgs[0];
                    row1 = int.Parse(cmdArgs[1]);
                    col1 = int.Parse(cmdArgs[2]);
                    row2 = int.Parse(cmdArgs[3]);
                    col2 = int.Parse(cmdArgs[4]);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                
                if (action == "swap" && cmdArgs.Length == 5 && row1 >= 0 && row1 < rowsCount && col1 >= 0 && col1 < colsCount && row2 >= 0 && row2 < rowsCount && col2 >= 0 && col2 < colsCount)
                {
                    string temp = String.Empty;
                    temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    PrintMatrix(matrix, rowsCount, colsCount);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                   
                }
                command = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] matrix, int rowsCount, int colsCount)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
