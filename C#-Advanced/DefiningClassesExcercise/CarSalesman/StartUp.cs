using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>(); 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double power = double.Parse(input[1]);
                if (input.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (input.Length == 3)
                {
                    int ignoreMe = 0;
                    bool isInt = int.TryParse(input[2], out ignoreMe);
                    
                    if (isInt)
                    {
                        double displace = double.Parse(input[2]);
                        engines.Add(new Engine(model, power, displace));
                    }
                    else
                    {
                        string efficient = input[2];
                        engines.Add(new Engine(model, power, efficient));
                    }
                }
                else if (input.Length == 4)
                {
                    double displace = double.Parse(input[2]);
                    string efficient = input[3];
                    engines.Add(new Engine(model, power, displace, efficient));
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                Engine givenEngine = engines.Where(x => x.Model == engineModel).FirstOrDefault();
                if (input.Length == 2)
                {
                    cars.Add(new Car(model, givenEngine));
                }
                else if (input.Length == 3)
                {
                    double ignoreMe = 0;
                    bool isInt = double.TryParse(input[2], out ignoreMe);
                    if (isInt)
                    {
                        double weight = double.Parse(Console.ReadLine());
                        cars.Add(new Car(model, givenEngine, weight));
                    }
                    else
                    {
                        string color = input[2];
                        cars.Add(new Car(model, givenEngine, color));
                    }
                }
                else if (input.Length == 4)
                {
                    double weight = double.Parse(input[2]);
                    string color = input[3];
                    cars.Add(new Car(model, givenEngine, weight, color));
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                string displacementFormat = car.Engine.Displacement == 0 ? "n/a" : $"{car.Engine.Displacement}";
                string efficiencyFormat = car.Engine.Efficiency == null ? "n/a" : $"{car.Engine.Efficiency}";
                Console.WriteLine($"    Displacement: {displacementFormat}");
                Console.WriteLine($"    Efficiency: {efficiencyFormat}");
                string wweightFormat = car.Weight == 0 ? "n/a" : $"{car.Weight}";
                string colorFormat = car.Color == null ? "n/a" : $"{car.Color}";
                Console.WriteLine($"  Weight: {wweightFormat}");
                Console.WriteLine($"  Color: {colorFormat}");
            }
        }
    }
}
