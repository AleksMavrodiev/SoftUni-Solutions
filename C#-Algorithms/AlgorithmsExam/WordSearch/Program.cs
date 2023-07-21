using System;
using System.Collections.Generic;

namespace WordSearch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] grid = new char[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = line[c];
                }
            }

            string[] words = Console.ReadLine().Split(' ');

            List<string> foundWords = FindWords(grid, words);

            Console.WriteLine(String.Join("\n", foundWords));
        }

        static List<string> FindWords(char[,] grid, string[] words)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            List<string> foundWords = new List<string>();

            foreach (string word in words)
            {
                bool[,] visited = new bool[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (grid[r, c] == word[0] && FoundWord(grid, visited, word, r, c, 0))
                        {
                            foundWords.Add(word);
                            break;
                        }
                    }
                }
            }

            return foundWords;
        }

        static bool FoundWord(char[,] grid, bool[,] visited, string word, int row, int col, int index)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (index == word.Length)
            {
                return true;
            }

            if (row < 0 || row >= rows || col < 0 || col >= cols || visited[row, col] || grid[row, col] != word[index])
            {
                return false;
            }

            visited[row, col] = true;

            if (FoundWord(grid, visited, word, row - 1, col - 1, index + 1) ||
                FoundWord(grid, visited, word, row - 1, col, index + 1) ||
                FoundWord(grid, visited, word, row , col + 1, index + 1) ||
                FoundWord(grid, visited, word, row, col - 1, index + 1) ||
                FoundWord(grid, visited, word, row, col + 1, index + 1) ||
                FoundWord(grid, visited, word, row + 1, col - 1, index + 1) ||
                FoundWord(grid, visited, word, row + 1, col, index + 1) ||
                FoundWord(grid, visited, word, row + 1, col + 1, index + 1))
            {
                visited[row, col] = false;
                return true;
            }

            visited[row, col] = false;
            return false;
        }
    }
}
