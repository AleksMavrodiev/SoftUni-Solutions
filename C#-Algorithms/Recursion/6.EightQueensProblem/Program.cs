using System;
using System.Collections.Generic;

namespace _6.EightQueensProblem
{
    internal class Program
    {
        private static HashSet<int> attackRows = new HashSet<int>();
        private static HashSet<int> attackCol = new HashSet<int>();
        private static HashSet<int> attackLeftDiagonal = new HashSet<int>();
        private static HashSet<int> attackRightDiagonal = new HashSet<int>();
        static void Main(string[] args)
        {
            var board = new bool[8, 8];

            PutQueens(board, 0);
        }

        private static void PutQueens(bool[,] board, int row)
        {
            if (row >= board.GetLength(0))
            {
                printBoard(board);
                Console.WriteLine();
            }

            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    attackRows.Add(row);
                    attackCol.Add(col);
                    attackLeftDiagonal.Add(row - col);
                    attackRightDiagonal.Add(row + col);
                    board[col, row] = true;

                    PutQueens(board, row + 1);

                    attackRows.Remove(row);
                    attackCol.Remove(col);
                    attackLeftDiagonal.Remove(row - col);
                    attackRightDiagonal.Remove(row + col);
                    board[col, row] = false;
                }
            }
        }

        private static void printBoard(bool[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !attackRows.Contains(row) && 
                   !attackCol.Contains(col) &&
                   !attackLeftDiagonal.Contains(row - col) &&
                   !attackRightDiagonal.Contains(row + col);
        }
    }
}
