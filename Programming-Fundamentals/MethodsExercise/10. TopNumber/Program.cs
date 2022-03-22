using System;

namespace _10._TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                CheckTopNumber(i);
            }
        }

        static bool CheckDivisibleBy8(int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckOddDigit(int number)
        {
            int counter = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    counter++;
                }
                number /= 10;
            }
            if (counter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void CheckTopNumber(int number)
        {
            if (CheckDivisibleBy8(number) && CheckOddDigit(number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
