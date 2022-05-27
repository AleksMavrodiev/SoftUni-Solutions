using System;
using System.Linq;

namespace _6._JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jagged[row] = new int[nums.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = nums[col];
                }
            }
            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                int rowIndex = int.Parse(cmdArgs[1]);
                int colIndex = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                if (rowIndex < 0 || rowIndex >= rows || colIndex < 0 || colIndex >= jagged[rowIndex].Length)
                {
                    continue;
                }
                else
                {
                    if (action == "Add")
                    {
                        jagged[rowIndex][colIndex] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jagged[rowIndex][colIndex] -= value;
                    }
                }
            }
            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
