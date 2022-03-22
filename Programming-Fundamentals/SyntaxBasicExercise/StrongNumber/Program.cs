using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long sum = 0;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                char digit = number[i];
                int currDigit = (int)digit - 48;

                long currDigitFactorial = 1;
                for (int r = currDigit; r > 1; r--)
                {
                    currDigitFactorial *= r;
                }
                sum += currDigitFactorial;
            }
            if (sum.ToString() == number)
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
