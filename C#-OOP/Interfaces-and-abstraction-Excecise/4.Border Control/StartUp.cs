using System;
using System.Collections.Generic;

namespace _4.Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> habitants = new List<IIdentifiable>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (cmdArgs.Length > 2)
                {
                    string name = cmdArgs[0];
                    int age = int.Parse(cmdArgs[1]);
                    string id = cmdArgs[2];
                    IIdentifiable person = new Citizen(name, age, id);
                    habitants.Add(person);
                }
                else
                {
                    string model = cmdArgs[0];
                    string id = cmdArgs[1];
                    IIdentifiable robot = new Robot(model, id);
                    habitants.Add(robot);
                }
            }

            string invalidEnd = Console.ReadLine();
            foreach (var habitant in habitants)
            {
                if (habitant.Id.EndsWith(invalidEnd))
                {
                    Console.WriteLine(habitant.Id);
                }
            }
        }
    }
}
