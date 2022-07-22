using System;
using System.Collections.Generic;

namespace _4.Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthdayBoys = new List<IBirthable>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ');
                string birthableType = cmdArgs[0];
                string name = cmdArgs[1];
                if (birthableType == "Citizen")
                {
                    int age = int.Parse(cmdArgs[2]);
                    string id = cmdArgs[3];
                    string year = cmdArgs[4];
                    IBirthable citizen = new Citizen(name, age, id, year);
                    birthdayBoys.Add(citizen);
                }
                else if (birthableType == "Pet")
                {
                    string birthDate = cmdArgs[2];
                    IBirthable pet = new Pet(name, birthDate);
                    birthdayBoys.Add(pet);
                }
                else
                {
                    continue;
                }
            }

            string givenYear = Console.ReadLine();
            
            foreach (var boy in birthdayBoys)
            {
                if (boy.BirthDate.EndsWith(givenYear))
                {
                    Console.WriteLine(boy.BirthDate);
                    
                }
            }
            

        }
    }
}
