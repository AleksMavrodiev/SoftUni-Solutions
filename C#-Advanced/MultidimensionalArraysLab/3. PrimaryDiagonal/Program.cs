using System;
using System.Linq;

namespace _3._PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int[,] matrice = new int[input, input];
            int sum = 0;
            for (int row = 0; row < matrice.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrice.GetLength(1); col++)
                {
                    matrice[row, col] = line[col];
                }
            }
            for (int row = 0; row < matrice.GetLength(0); row++)
            {
                sum += matrice[row, row];
            }
            Console.WriteLine(sum);
        }
    }
}
