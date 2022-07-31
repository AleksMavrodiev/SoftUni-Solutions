using System;
using System.Collections.Generic;

namespace _2.EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int previousNumber = 1;
            while (numbers.Count < 10)
            {
                try
                {
                    int max = 100;
                    
                    int number = int.Parse(Console.ReadLine());
                    ReadNumber(previousNumber, max, number);
                    numbers.Add(number);
                    previousNumber = number;
            }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }

        static void ReadNumber(int start, int end, int currNumber)
        {
            if (currNumber <= start || currNumber >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - {end}!");
            }
        }
    }
}
