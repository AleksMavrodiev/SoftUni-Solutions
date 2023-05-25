using System;
using System.Collections.Generic;

namespace _5.RecursiveLabyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var lab = new char[rows, cols];
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                var colElements = Console.ReadLine();
                for (int col = 0; col < colElements.Length; col++)
                {
                    lab[row, col] = colElements[col];
                }
            }

            FindPath(lab, 0, 0, new List<string>(), string.Empty);
        }

        private static void FindPath(char[,] lab, int row, int col, List<string> directions, string direction)
        {
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            if (lab[row, col] == '*' || lab[row, col] == 'v')
            {
                return;
            }

            
            directions.Add(direction);

            if (lab[row, col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = 'v';


            FindPath(lab, row - 1, col, directions, "U");
            FindPath(lab, row + 1, col, directions, "D");
            FindPath(lab, row, col - 1, directions, "L");
            FindPath(lab, row, col + 1, directions, "R");

            lab[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}
