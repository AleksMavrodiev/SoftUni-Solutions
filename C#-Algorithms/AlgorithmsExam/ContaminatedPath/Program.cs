using System;
using System.Collections.Generic;
using System.Linq;

namespace ContaminatedPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            var dp = new int[n, n];
            dp[0, 0] = matrix[0, 0];
            for (int c = 1; c < n; c++)
            {
                dp[0, c] = dp[0, c - 1] + matrix[0, c];
            }

            for (int r = 1; r < n; r++)
            {
                dp[r, 0] = dp[r - 1, 0] + matrix[r, 0];
            }

            for (int r = 1; r < n; r++)
            {
                for (int c = 1; c < n; c++)
                {
                    var upper = dp[r - 1, c];
                    var left = dp[r, c - 1];

                    dp[r, c] = Math.Max(upper, left) + matrix[r, c];
                }
            }

            string[] contaminatedCells = Console.ReadLine().Split(' ');

            HashSet<string> contaminatedSet = new HashSet<string>(contaminatedCells);

            var path = new Stack<string>();

            var row = n - 1;
            var col = n - 1;

            path.Push($"({row}, {col})");

            while (row > 0 && col > 0)
            {
                var upper = dp[row - 1, col];
                var left = dp[row, col - 1];

                
                if (upper > left)
                {
                    if (CheckContaminated(row - 1, col, contaminatedSet))
                    {
                        col--;
                    }
                    else
                    {
                        row--;
                    }
                }
                else
                {
                    if (CheckContaminated(row, col - 1, contaminatedSet))
                    {
                        row--;
                    }
                    else
                    {
                        col--;
                    }
                }

                path.Push($"({row}, {col})");
            }

            while (row > 0)
            {
                row--;
                path.Push($"({row}, {col})");
            }

            while (col > 0)
            {
                col--;
                path.Push($"({row}, {col})");
            }


            Console.WriteLine($"Max total fertility: {dp[n - 1, n - 1]}");
            Console.WriteLine($"[{string.Join(" ", path)}]");
        }

        private static bool CheckContaminated(int row, int col, HashSet<string> contaminatedCells)
        {
            bool isContaminated = false;
            string expression = $"{row},{col}";
            if (contaminatedCells.Contains(expression))
            {
                isContaminated = true;
            }

            return isContaminated;
        }
    }
}