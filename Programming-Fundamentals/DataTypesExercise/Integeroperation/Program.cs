using System;

namespace Integeroperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fisrtNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long sum = (long)fisrtNumber + secondNumber;
            long divide = sum / thirdNumber;
            long multi = divide * fourthNumber;
            Console.WriteLine(multi);
        }
    }
}
