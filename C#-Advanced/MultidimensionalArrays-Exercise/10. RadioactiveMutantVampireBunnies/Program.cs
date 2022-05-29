using System;
using System.Linq;

namespace _10._RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowCount = input[0];
            int colCount = input[1];
            char[,] matrix = new char[rowCount, colCount];
            int startRow = -1;
            int startCol = -1;
            bool isAlive = true;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'P')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            string directions = Console.ReadLine();
            for (int i = 0; i < directions.Length; i++)
            {
                if (directions[i] == 'U')
                {
                    if (ValidIndex(startRow - 1, startCol, rowCount, colCount))
                    {
                        if (matrix[startRow - 1, startCol] == '.')
                        {
                            
                            startRow -= 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                        }
                        else
                        {
                            isAlive = false;
                            startRow -= 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                            break;
                        }
                        
                    }
                }
                else if (directions[i] == 'L')
                {
                    if (ValidIndex(startRow, startCol - 1, rowCount, colCount))
                    {
                        if (matrix[startRow, startCol - 1] == '.')
                        {
                            
                            startCol -= 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                        }
                        else
                        {
                            isAlive = false;
                            startCol -= 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                            break;
                        }
                        
                    }
                }
                else if (directions[i] == 'R')
                {
                    if (ValidIndex(startRow, startCol + 1, rowCount, colCount))
                    {
                        if (matrix[startRow, startCol + 1] == '.')
                        {
                            
                            startCol += 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                        }
                        else
                        {
                            isAlive = false;
                            startCol += 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                            break;
                        }
                        
                    }
                }
                else if (directions[i] == 'D')
                {
                    if (ValidIndex(startRow + 1, startCol, rowCount, colCount))
                    {
                        if (matrix[startRow + 1, startCol] == '.')
                        {
                            
                            startRow += 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                        }
                        else
                        {
                            isAlive = false;
                            startRow += 1;
                            PopulateBunnies(matrix, rowCount, colCount);
                            break;
                        }
                        
                    }
                }
            }
            PrintMatrix(matrix);
            if (isAlive)
            {
                Console.WriteLine($"won: {startRow} {startCol}");
            }
            else
            {
                Console.WriteLine($"dead: {startRow} {startCol}");
            }
        }

        static void PopulateBunnies(char[,] matrix, int rowSize, int colSize)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (ValidIndex(row, col - 1, rowSize, colSize))
                        {
                            matrix[row, col - 1] = 'B';
                        }
                        if (ValidIndex(row - 1, col, rowSize, colSize))
                        {
                            matrix[row - 1, col] = 'B';
                        }
                        if (ValidIndex(row, col + 1, rowSize, colSize))
                        {
                            matrix[row, col + 1] = 'B';
                        }
                        if (ValidIndex(row + 1, col, rowSize, colSize))
                        {
                            matrix[row + 1, col] = 'B';
                        }
                    }
                }
            }
        }

        static bool ValidIndex(int row, int col, int rowSize, int colSize)
        {
            if (row < 0 || row >= rowSize || col < 0 || col >= colSize)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
