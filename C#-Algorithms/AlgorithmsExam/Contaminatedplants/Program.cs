using System;
using System.Collections.Generic;

namespace Contaminatedplants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = int.Parse(row[c]);
                }
            }

            string[] contaminatedCells = Console.ReadLine().Split(' ');

            HashSet<string> contaminatedSet = new HashSet<string>(contaminatedCells);

            int[,] dp = new int[n, n];
            dp[0, 0] = matrix[0, 0];

            string[,] bestPath = new string[n, n];
            bestPath[0, 0] = "(0, 0)";

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (contaminatedSet.Contains($"{r},{c}"))
                    {
                        continue;
                    }

                    if (r == 0 && c > 0)
                    {
                        if (!contaminatedSet.Contains($"{r},{c - 1}"))
                        {
                            dp[r, c] = dp[r, c - 1] + matrix[r, c];
                            bestPath[r, c] = bestPath[r, c - 1] + $" ({r}, {c})";
                        }
                    }
                    else if (c == 0 && r > 0)
                    {
                        if (!contaminatedSet.Contains($"{r - 1},{c}"))
                        {
                            dp[r, c] = dp[r - 1, c] + matrix[r, c];
                            bestPath[r, c] = bestPath[r - 1, c] + $" ({r}, {c})";
                        }
                    }
                    else if (r > 0 && c > 0)
                    {
                        int aboveFertility = dp[r - 1, c];
                        int leftFertility = dp[r, c - 1];

                        if (!contaminatedSet.Contains($"{r - 1},{c}") && !contaminatedSet.Contains($"{r},{c - 1}"))
                        {
                            if (aboveFertility > leftFertility)
                            {
                                dp[r, c] = aboveFertility + matrix[r, c];
                                bestPath[r, c] = bestPath[r - 1, c] + $" ({r}, {c})";
                            }
                            else
                            {
                                dp[r, c] = leftFertility + matrix[r, c];
                                bestPath[r, c] = bestPath[r, c - 1] + $" ({r}, {c})";
                            }
                        }
                        else if (!contaminatedSet.Contains($"{r - 1},{c}"))
                        {
                            dp[r, c] = aboveFertility + matrix[r, c];
                            bestPath[r, c] = bestPath[r - 1, c] + $" ({r}, {c})";
                        }
                        else if (!contaminatedSet.Contains($"{r},{c - 1}"))
                        {
                            dp[r, c] = leftFertility + matrix[r, c];
                            bestPath[r, c] = bestPath[r, c - 1] + $" ({r}, {c})";
                        }
                    }
                }
            }

            int fertility = dp[n - 1, n - 1];
            string path = bestPath[n - 1, n - 1];
            Console.WriteLine($"Max total fertility: {fertility}");
            Console.WriteLine($"[{path}]");
        }
    }
}
