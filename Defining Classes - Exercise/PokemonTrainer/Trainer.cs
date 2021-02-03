using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, int badges, Pokemon pokemon)
        {
            Name = name;
            Badges = badges;
            Pokemons = new List<Pokemon>() { pokemon };
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}
