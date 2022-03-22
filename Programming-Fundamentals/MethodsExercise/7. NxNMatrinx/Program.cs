using System;

namespace _7._NxNMatrinx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintColumn(number);
        }

        static void PrintRow(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        static void PrintColumn(int number)
        {
            for (int i = 0; i < number; i++)
            {
                PrintRow(number);
            }
        }
    }
}
