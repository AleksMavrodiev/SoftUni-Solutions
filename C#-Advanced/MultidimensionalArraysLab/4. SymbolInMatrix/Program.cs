using System;

namespace _4._SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrice = new int[input, input];
            int rowIndex = 0;
            int colIndex = 0;
            bool isFound = false;
            for (int row = 0; row < matrice.GetLength(0); row++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrice.GetLength(1); col++)
                {
                    matrice[row, col] = line[col];
                }
            }
            char symbolSeatched = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrice.GetLength(0); row++)
            {
                for (int col = 0; col < matrice.GetLength(1); col++)
                {
                    if (matrice[row, col] == symbolSeatched)
                    {
                        rowIndex = row;
                        colIndex = col;
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({rowIndex}, {colIndex})");
            }
            else
            {
                Console.WriteLine($"{symbolSeatched} does not occur in the matrix");
            }
        }
    }
}
