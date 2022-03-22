using System;

namespace _1._FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double appronPrice = double.Parse(Console.ReadLine());
            double appronAmount = Math.Ceiling(studentCount * 1.2);
            double eggAmount = studentCount * 10;
            double flourAmount = studentCount - (studentCount / 5);
            double total = (flourPrice * flourAmount) + (eggPrice * eggAmount) + (appronPrice * appronAmount);
            if (total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:F2}$.");
            }
            else
            {
                Console.WriteLine($"{total - budget:F2}$ more needed.");
            }
        }
    }
}
