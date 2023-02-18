using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Trainer trainer = trainers.SingleOrDefault(t => t.Name == tokens[0]);

                if (trainer == null)
                {
                    trainer = new Trainer(tokens[0]);
                    trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
                }
            }

            string command2;
            while ((command2 = Console.ReadLine()) != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    trainer.CheckPokemon(command2);
                }
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
