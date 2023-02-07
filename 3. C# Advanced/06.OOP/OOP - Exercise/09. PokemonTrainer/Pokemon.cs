using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._PokemonTrainer
{
    public class Pokemon
    {
        private string pokemonName;
        private string element;
        private int health;

        public Pokemon(string pokemonName, string element, int health)
        {
            PokemonName = pokemonName;
            Element = element;
            Health = health;
        }

        public string PokemonName
        {
            get { return pokemonName; }
            set { pokemonName = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    }
}
