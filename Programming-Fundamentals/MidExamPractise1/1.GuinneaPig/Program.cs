using System;

namespace _1.GuinneaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double guinneaWeght = double.Parse(Console.ReadLine()) * 1000;
            double hayGiven;
            double coverGiven = guinneaWeght / 3.00;
            bool isEnough = true;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                  
                    hayGiven = food * 0.05;
                    hay -= hayGiven;
                    
                }
                if (i % 3 == 0)
                {
                    
                    cover -= coverGiven;
                    
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    isEnough = false;
                    break;
                }
            }
            if (isEnough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:F2}, Hay: {hay / 1000:F2}, Cover: {cover / 1000:F2}.");
            }
        }
    }
}
