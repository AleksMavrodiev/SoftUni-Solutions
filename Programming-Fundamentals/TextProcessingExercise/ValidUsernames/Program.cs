using System;

namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string name in names)
            {
                if (ValidateName(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        static bool ValidateName(string name)
        {
            bool isValid = true;
            if (name.Length < 3 || name.Length > 16)
            {
                isValid = false;
                return isValid;
            }
            foreach (var character in name)
            {
                if (!char.IsLetterOrDigit(character) && character != '-' && character != '_')
                {
                    isValid = false;
                    
                }
            }
            return isValid;
        }
    }

}
