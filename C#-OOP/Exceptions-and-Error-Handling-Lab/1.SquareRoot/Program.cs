using System;

namespace _1.SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculateSqrt(number));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        static double CalculateSqrt(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }
            return Math.Sqrt(number);
        }
    }
}
