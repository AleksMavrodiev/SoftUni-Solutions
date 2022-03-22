using System;

namespace SMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 0;
            int digit = 0;
            int offset;
            string word = string.Empty;
            while (command != "Stop")
            {
                int number = int.Parse(command);
                while (number != 0)
                {
                    digit = number % 10;
                    number /= 10;
                    counter++;
                }
                offset = (digit - 2) * 3;
                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int index = offset + counter - 1 + 97;
                word += (char)index;
                counter = 0;
                command = Console.ReadLine();
            }
            Console.WriteLine(word);
        }
    }
}
