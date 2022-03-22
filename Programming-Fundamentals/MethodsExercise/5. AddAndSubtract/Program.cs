using System;

namespace _5._AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = SumFirstTwo(firstNum, secondNum);
            Console.WriteLine(SubtractThird(sum, thirdNum));
        }

        static int SumFirstTwo(int first, int second)
        {
            return first + second;
        }

        static int SubtractThird(int sum, int third)
        {
            return sum - third;
        }
    }
}
