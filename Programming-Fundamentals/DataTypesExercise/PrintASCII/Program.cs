using System;

namespace PrintASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sratIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (int i = sratIndex; i <= endIndex; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}
