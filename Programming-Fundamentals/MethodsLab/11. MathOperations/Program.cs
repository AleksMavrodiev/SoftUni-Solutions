using System;

namespace _11._MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Calculate(firstNum, @operator, secondNum)}");
        }

        static double Calculate(double firstNum, string @operator, double secondNum)
        {
            switch (@operator)
            {
                case "+":
                    return firstNum + secondNum;
                    break;
                case "-":
                    return firstNum - secondNum;
                    break;
                case "*":
                    return firstNum * secondNum;
                    break;
                case "/":
                    return firstNum / secondNum;
                    break;
            }
            return 0;
        } 
    }
}
