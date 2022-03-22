using System;

namespace Refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int num = 0;
            bool isMagic = false;
            for (int i = 1; i <= n; i++)
            {
                num = i;
                int sum = 0;
                
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num = num / 10;
                }
                isMagic = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isMagic);
                 
                
            }

        }
    }
}
