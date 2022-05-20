using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._TruckTour
{
    class Pump
    {
        public Pump(int index, int fuel, int distanceToNext)
        {
            this.Index = index;
            this.Fuel = fuel;
            this.DistanceToNext = distanceToNext;
        }
        public int Index { get; set; }
        public int Fuel { get; set; }
        public int DistanceToNext { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Pump> circle = new Queue<Pump>();
            long currentFuel = 0;
            int startIndex = int.MinValue;
            int numberPumps = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberPumps; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = data[0];
                int distance = data[1];
                circle.Enqueue(new Pump(i, fuel, distance));
            }
            while (true)
            {
                bool isValid = true;
                foreach (var pump in circle)
                {
                    startIndex = circle.Peek().Index;
                    currentFuel += circle.Peek().Fuel;
                    int disctance = circle.Peek().DistanceToNext;
                    Pump currPump = new Pump(startIndex, circle.Peek().Fuel, disctance);
                    
                    if(currentFuel - disctance < 0)
                    {
                        isValid = false;
                        startIndex = int.MinValue;
                        currentFuel = 0;
                        circle.Dequeue();
                        circle.Enqueue(currPump);
                        break;
                    }
                    currentFuel -= disctance;
                }
                if (isValid)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
            
        }
    }
}
