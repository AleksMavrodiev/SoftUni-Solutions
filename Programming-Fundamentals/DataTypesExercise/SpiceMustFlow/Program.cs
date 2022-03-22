using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int currYield = startYield;
            int dayCount = 0;
            int total = 0;
            while (currYield >= 100)
            {
                total += currYield;
                if (total >= 26)
                {
                    total -= 26;
                }
                currYield -= 10;
                dayCount++;
            }
            if (total >= 26)
            {
                total -= 26;
            }
            Console.WriteLine(dayCount);
            Console.WriteLine(total);
        }
    }
}
