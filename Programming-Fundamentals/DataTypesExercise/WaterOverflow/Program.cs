using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                if (pour > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                capacity -= pour;
                sum += pour;
            }
            Console.WriteLine(sum);
        }
    }
}
