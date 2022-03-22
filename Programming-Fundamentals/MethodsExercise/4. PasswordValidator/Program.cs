using System;

namespace _4._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            ValidatePassword(password);
        }

        static bool CheckPasswordLength(string password)
        {
            if (password.Length > 10 || password.Length < 6)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool CheckLettersDigits(string password)
        {
            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    
                    return false;
                }
               
            }
            return true;
        }

        static bool CheckDigitCount(string password)
        {
            int digitCount = 0;
            foreach(char c in password)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
            }
            if(digitCount < 2)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }

        static void ValidatePassword(string password)
        {
            bool isValid = true;
            if (!CheckPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!CheckLettersDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!CheckDigitCount(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
