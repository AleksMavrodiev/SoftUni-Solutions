using System;

namespace _4.RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFactorial(num));
        }

        private static int CalcFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * CalcFactorial(num - 1);
        }
    }
}
