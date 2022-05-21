using System;
using System.Linq;

namespace _1._SumMatrxiElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split(", ")[0]);
            int cols = int.Parse(input.Split(", ")[1]);
            int[,] matrice = new int[rows, cols];
            int sum = 0;
            for (int row = 0; row < matrice.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrice.GetLength(1); col++)
                {
                    matrice[row, col] = line[col];
                }
            }
            foreach (var number in matrice)
            {
                sum += number;
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
