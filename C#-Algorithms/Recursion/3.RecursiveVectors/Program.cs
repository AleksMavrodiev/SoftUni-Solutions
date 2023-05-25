using System;

namespace _3.RecursiveVectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            int index = 0;
            DrawVectors(index, vector);
        }

        private static void DrawVectors(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                DrawVectors(index + 1, vector);
            }
        }
    }
}
