using System;

namespace _7.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];
            
            for (int row = 0; row < size; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    board[row, col] = line[col];
                }
            }

            int knightsToRemove = 0;
            while (true)
            {
                int rowOfKnight = -1;
                int colOfKnight = -1;
                int currAttack = 0;
                int attack = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                         currAttack = CalculateAttacks(board, row, col, size);
                        if (currAttack > attack)
                        {
                            attack = currAttack;
                            rowOfKnight = row;
                            colOfKnight = col;
                        }
                    }
                }
                if (attack > 0)
                {
                    board[rowOfKnight, colOfKnight] = '0';
                    knightsToRemove++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(knightsToRemove);
        }
        static int CalculateAttacks(char[,] board, int row, int col, int size)
        {
            int currAttack = 0;
            if (ValidateIndex(row - 2, col + 1, size))
            {
                if (board[row - 2, col + 1] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row - 2, col - 1, size))
            {
                if (board[row - 2, col - 1] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row - 1, col + 2, size))
            {
                if (board[row - 1, col + 2] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row - 1, col - 2, size))
            {
                if (board[row - 1, col - 2] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row + 1, col - 2, size))
            {
                if (board[row + 1, col - 2] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row + 1, col + 2, size))
            {
                if (board[row + 1, col + 2] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row + 2, col - 1, size))
            {
                if (board[row + 2, col - 1] == 'K')
                {
                    currAttack++;
                }
            }
            if (ValidateIndex(row + 2, col + 1, size))
            {
                if (board[row + 2, col + 1] == 'K')
                {
                    currAttack++;
                }
            }
            return currAttack;
        }
        static bool ValidateIndex(int rowIndex, int colIndex, int size)
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
    }
}
