using System;
using System.Linq;
using System.Numerics;

namespace FromLeftToRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
                if (arr[0] >= arr[1])
                {
                    while (arr[0] != 0)
                    {
                        sum += arr[0] % 10;
                        arr[0] /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
                else
                {
                    while (arr[1] != 0)
                    {
                        sum += arr[1] % 10;
                        arr[1] /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                }
                sum = 0;
            }
        }
    }
}
