using System;

namespace FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal diff = Math.Abs(Math.Abs(a) - Math.Abs(b));
            decimal eps = 0.000001M;
            if (diff >= eps)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
