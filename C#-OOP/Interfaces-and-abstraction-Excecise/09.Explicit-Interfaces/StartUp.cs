using System;

namespace _09.Explicit_Interfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string name = cmdArgs[0];
                string country = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                Citizen citizen = new Citizen(name, country, age);
                IPerson person = citizen;
                IResident resident = citizen;
                person.GetName();
                resident.GetName();
            }
        }
    }
}
