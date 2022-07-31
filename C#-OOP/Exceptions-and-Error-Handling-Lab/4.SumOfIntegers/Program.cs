using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SumOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                int number = 0;
                try
                {
                    number = int.Parse(input[i]);
                    numbers.Add(number);
                }
                catch (FormatException)
                {

                    Console.WriteLine($"The element '{input[i]}' is in wrong format!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"The element '{input[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {numbers.Sum()}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");
        }
    }
}
