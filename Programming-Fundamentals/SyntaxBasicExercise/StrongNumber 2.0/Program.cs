using System;

namespace StrongNumber_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int convert = int.Parse(number);
            int factorialSum = 0;
            for (int i = number.Length; i >= 1; i--)
            {
                int digit = convert % 10;
                convert /= 10;
                int factorMulti = 1;
                for (int r = digit; r > 1; r--)
                {
                    factorMulti *= r;
                }
                factorialSum += factorMulti;
            }
            if (number == factorialSum.ToString())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
