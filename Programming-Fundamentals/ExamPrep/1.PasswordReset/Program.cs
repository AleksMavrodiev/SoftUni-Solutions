using System;
using System.Linq;

namespace _1.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "TakeOdd")
                {
                    var oddChars = password.Where((character, index) => index % 2 != 0);
                    password = string.Join("", oddChars);
                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int length = int.Parse(cmdArgs[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, replacement);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
