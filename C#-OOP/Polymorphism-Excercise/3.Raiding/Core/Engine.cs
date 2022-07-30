using _3.Raiding.Factories;
using _3.Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Raiding.Core
{
    public class Engine : IEngine
    {
        public void Start()
        {
            List<BaseHero> heroes = new List<BaseHero>();   
            int n = int.Parse(Console.ReadLine());
            while (heroes.Count < n)
            {
                try
                {
                    BaseHero hero;
                    string heroName = Console.ReadLine();
                    string heroType = Console.ReadLine();
                    HeroFactory factory = new HeroFactory();
                    hero = factory.CreateHero(heroType, heroName);
                    heroes.Add(hero);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
            double bossPower = double.Parse(Console.ReadLine());
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }
            double sumPower = heroes.Sum(x => x.Power);
            if (sumPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
