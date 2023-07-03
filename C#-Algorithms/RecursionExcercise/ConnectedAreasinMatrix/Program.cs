using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedAreasinMatrix
{
    internal class Program
    {
        public class Area
        {
            public int Row { get; set; }
            public int Column { get; set; }
            public int Size { get; set; }
        }


        private static char[,] matrix;
        private static int size = 0;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            List<Area> areas = new List<Area>();

            matrix = new char[rows, cols];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    
                    matrix[r, c] = line[c];
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    size = 0;
                    ExploreArea(r, c);
                    if (size != 0)
                    {
                        areas.Add(new Area(){Row = r, Column = c, Size = size});
                    }
                }
            }
            
            

            Console.WriteLine($"Total areas found: {areas.Count}");
            int index = 1;

            foreach (var area in areas.OrderByDescending(a => a.Size).ThenBy(a => a.Row).ThenBy(a => a.Column))
            {
                Console.WriteLine($"Area #{index} at ({area.Row}, {area.Column}), size: {area.Size}");
                index++;
            }
        }

        private static void ExploreArea(int rows, int cols)
        {
            if (isOutside(rows, cols) || isWall(rows, cols) || matrix[rows, cols] == 'v')
            {
                return;
            }

            size += 1;
            matrix[rows, cols] = 'v';

            ExploreArea(rows - 1, cols);
            ExploreArea(rows + 1, cols);
            ExploreArea(rows, cols - 1);
            ExploreArea(rows, cols + 1);
        }

        private static bool isWall(int rows, int cols)
        {
            if (matrix[rows, cols] == '*')
            {
                return true;
            }

            return false;
        }

        private static bool isOutside(int rows, int cols)
        {
            return rows < 0 || cols < 0 || rows >= matrix.GetLength(0) || cols >= matrix.GetLength(1);
        }
    }
}
