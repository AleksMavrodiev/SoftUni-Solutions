using System;

namespace _2._SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>", StringSplitOptions.RemoveEmptyEntries);
            double total = 0.0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                string[] carDetails = vehicles[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carType = carDetails[0];
                int years = int.Parse(carDetails[1]);
                int kilometers = int.Parse(carDetails[2]);
                if (carType == "family")
                {
                    int initialTax = 50;
                    int decline = 5;
                    double tax = (kilometers / 3000) * 12 + (initialTax - years * decline);
                    Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
                    total += tax;
                }
                else if (carType == "heavyDuty")
                {
                    int initialTax = 80;
                    int decline = 8;
                    double tax = (kilometers / 9000) * 14 + (initialTax - years * decline);
                    Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
                    total += tax;
                }
                else if (carType == "sports")
                {
                    int initialTax = 100;
                    int decline = 9;
                    double tax = (kilometers / 2000) * 18 + (initialTax - years * decline);
                    Console.WriteLine($"A {carType} car will pay {tax:F2} euros in taxes.");
                    total += tax;
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }
            Console.WriteLine($"The National Revenue Agency will collect {total:F2} euros in taxes.");
        }
    }
}
