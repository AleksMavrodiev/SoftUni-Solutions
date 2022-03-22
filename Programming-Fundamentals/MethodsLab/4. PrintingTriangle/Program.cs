using System;

namespace _4._PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                PrintLine(i);
            }
            for (int i = n; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
        static void PrintLine(int times)
        {
            for (int i = 1; i <= times; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
