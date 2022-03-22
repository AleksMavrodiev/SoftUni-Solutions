using System;

namespace _8._FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Divide2Factors(CalculateFactorial(firstNumber), CalculateFactorial(secondNumber));
        }

        static double CalculateFactorial(double number)
        {
            double @base = number;
            for (int i = (int)number - 1; i > 0; i--)
            {
                @base *= i;
            }
            return @base;
        }

        static void Divide2Factors(double first, double second)
        {
            double result = first / second;
            Console.WriteLine($"{result:F2}");
        }
    }
}
