using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = command.Split();
                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                double pokemonHEalth = double.Parse(cmdArgs[3]);
                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHEalth);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainerName, trainer);
                    
                }
                else
                {
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHEalth);
                    trainers[trainerName].Pokemons.Add(pokemon);
                    
                }
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Where(x => x.Element == input).Count() > 0)
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        //trainer.Value.Pokemons.ForEach(action);
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumberOfBadges} {trainer.Value.Pokemons.Count()}");
            }
        }

        //static Action<Pokemon> action = x => x.Health -= 10;
    }
}
