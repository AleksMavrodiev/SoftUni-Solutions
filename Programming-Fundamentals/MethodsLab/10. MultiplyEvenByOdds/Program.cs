using System;

namespace _10._MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = GetEvenSum(number);
            int oddSum = GetOddSum(number);
            Console.WriteLine(GetEvenOddMulti(evenSum, oddSum));
        }
        static int GetEvenSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                
                int digit = 0;
                digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
        static int GetOddSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {

                int digit = 0;
                digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
            }
            return sum;
        }
        static int GetEvenOddMulti(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
