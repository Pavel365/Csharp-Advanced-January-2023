using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
        }


        public string Name { get { return this.name; } set { this.name = value; } }

        public int NumberOfBadges { get { return this.numberOfBadges; } set { this.numberOfBadges = value; } }

        public List<Pokemon> Pokemons { get { return this.pokemons; } set { this.pokemons = value;} }

        public void CheckPokemon(string element)
        {
            if (this.Pokemons.Any(p => p.Element == element))
            {
                this.NumberOfBadges++;
            }
            else
            {
                for (int i = 0; i < this.Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = this.Pokemons[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        this.Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
