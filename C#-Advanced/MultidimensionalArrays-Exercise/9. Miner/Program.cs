using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] matrix = new char[size, size];
            int coalCount = 0;
            int startRow = -1;
            int startCol = -1;
            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'c')
                    {
                        coalCount++;
                    }
                    if (line[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    int newRow = startRow - 1;
                    int newCol = startCol;
                    if (ValidateIndex(size, newRow, newCol))
                    {
                        startRow -= 1;
               
                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCount--;
                            matrix[startRow, startCol] = '*';
                        }
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                        if (coalCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "left")
                {
                    int newRow = startRow;
                    int newCol = startCol - 1;
                    if (ValidateIndex(size, newRow, newCol))
                    {
                        startCol -= 1;
                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCount--;
                            matrix[startRow, startCol] = '*';
                        }
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                        if (coalCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "right")
                {
                    int newRow = startRow;
                    int newCol = startCol + 1;
                    if (ValidateIndex(size, newRow, newCol))
                    {
                        startCol += 1;
                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCount--;
                            matrix[startRow, startCol] = '*';
                        }
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                        if (coalCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[i] == "down")
                {
                    int newRow = startRow + 1;
                    int newCol = startCol;
                    if (ValidateIndex(size, newRow, newCol))
                    {
                        startRow += 1;

                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCount--;
                            matrix[startRow, startCol] = '*';
                        }
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                        if (coalCount <= 0)
                        {
                            Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine($"{coalCount} coals left. ({startRow}, {startCol})");
        }

        static bool ValidateIndex(int size, int row, int col)
        {
            if (row < 0 || row >= size || col < 0 || col >= size)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
