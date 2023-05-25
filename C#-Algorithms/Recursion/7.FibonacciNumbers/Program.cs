using System;

namespace _7.FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num++;
            Console.WriteLine(Fib(num));
        }

        public static int Fib(int num)
        {
            

            if (num <= 1)
            {
                return num;
            }
            else
            {
                return Fib(num - 1) + Fib(num - 2);
            }
        }
    }
}
