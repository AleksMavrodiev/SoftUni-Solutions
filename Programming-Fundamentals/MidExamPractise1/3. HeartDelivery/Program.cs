using System;
using System.Linq;

namespace _3._HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = string.Empty;
            int currentIndex = 0;
            int counter = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] cmdArgs = command.Split();
                int jumpLenghth = int.Parse(cmdArgs[1]);
                currentIndex += jumpLenghth;
                if (currentIndex >= neighborhood.Length)
                {
                    currentIndex = 0;
                }
                if (neighborhood[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    neighborhood[currentIndex] -= 2;
                    if (neighborhood[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
            }
            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            if (counter == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - counter} places.");
            }
        }
    }
}
