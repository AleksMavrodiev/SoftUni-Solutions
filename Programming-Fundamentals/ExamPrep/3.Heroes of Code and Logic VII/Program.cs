using System;
using System.Collections.Generic;

namespace _3.Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(int hitPoints, int manaPoints)
        {
            this.HP = hitPoints;
            this.MP = manaPoints;
            if (this.HP > 100)
            {
                this.HP = 100;
            }
            if (this.MP > 200)
            {
                this.MP = 200;
            }
        }
        public int HP { get; set; }
        public int MP { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int heroCount = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < heroCount; i++)
            {
                string hero = Console.ReadLine();
                string[] heroStats = hero.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroStats[0];
                int hitPoints = int.Parse(heroStats[1]);
                int manaPoints = int.Parse(heroStats[2]);
                heroes.Add(heroName, new Hero(hitPoints, manaPoints));
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string heroName = cmdArgs[1];
                if (action == "CastSpell")
                {
                    int manaRequired = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];
                    if (heroes[heroName].MP < manaRequired)
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroes[heroName].MP -= manaRequired;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];
                    heroes[heroName].HP -= damage;
                    if (heroes[heroName].HP <= 0)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int oldValue = heroes[heroName].MP;
                    heroes[heroName].MP += amount;
                    if (heroes[heroName].MP > 200)
                    {
                        heroes[heroName].MP = 200;
                    }
                    Console.WriteLine($"{heroName} recharged for {heroes[heroName].MP - oldValue} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);
                    int oldValue = heroes[heroName].HP;
                    heroes[heroName].HP += amount;
                    if (heroes[heroName].HP > 100)
                    {
                        heroes[heroName].HP = 100;
                    }
                    Console.WriteLine($"{heroName} healed for {heroes[heroName].HP - oldValue} HP!");
                }
            }
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }
    }
}
