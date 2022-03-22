using System;

namespace _3._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(action, firstNum, secondNum));
        }

        static int Calculate(string command, int num1, int num2)
        {
            switch (command)
            {
                case "add":
                    return num1 + num2;
                    break;
                case "multiply":
                    return num1 * num2;
                    break;
                case "subtract":
                    return num1 - num2;
                    break;
                case "divide":
                    return num1 / num2;
                    break;

            }
            return 0;
        }
    }
}
