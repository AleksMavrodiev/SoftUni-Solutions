using System;

namespace DataTypeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                int number = 0;
                double realNumber = 0;
                char a;
                bool maybe = false;
                string text = string.Empty;
                bool success = int.TryParse(command, out number);
                bool successDouble = double.TryParse(command, out realNumber);
                bool successChar = char.TryParse(command, out a);
                bool successBool = bool.TryParse(command, out maybe);
                
                if (success)
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if(successDouble)
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (successChar)
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if(successBool)
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
                command = Console.ReadLine();
            }
        }
    }
}
