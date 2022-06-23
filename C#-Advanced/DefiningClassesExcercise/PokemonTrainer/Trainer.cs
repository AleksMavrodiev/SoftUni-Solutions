using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        List<Pokemon> pokemons;
        

        public string Name { get => name; set => name = value; }
        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
       

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
           
        }
    }
}
