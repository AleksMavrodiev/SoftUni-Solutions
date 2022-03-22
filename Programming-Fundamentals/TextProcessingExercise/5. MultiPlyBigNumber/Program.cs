using System;
using System.Numerics;

namespace _5._MultiPlyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            BigInteger result = BigInteger.Multiply(firstNumber, secondNumber);
            Console.WriteLine(result);
        }
    }
}
