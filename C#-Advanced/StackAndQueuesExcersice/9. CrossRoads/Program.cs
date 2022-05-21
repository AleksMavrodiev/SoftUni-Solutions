using System;
using System.Collections.Generic;

namespace _9._CrossRoads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    
                }
            }
        }

        static void GreenLightSequence(Queue<string> cars, int greenLight, int freeWindow)
        {
            
        }
    }
}
