using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Trainer> Trainers = new List<Trainer>();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer isTrainerExist = Trainers.FirstOrDefault(x => x.Name == trainerName);
                if(Trainers.Contains(isTrainerExist))
                {
                    isTrainerExist.Pokemons.Add(currentPokemon);
                }
                else
                {
                    Trainer currentTrainer = new Trainer(trainerName, 0, currentPokemon);
                    Trainers.Add(currentTrainer);
                }
            }

            string secondCommand = string.Empty;

            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string currentElement = secondCommand;

                foreach (var trainer in Trainers)
                {
                    bool isElementExist = false;

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if(pokemon.Element == currentElement)
                        {
                            isElementExist = true;
                        }
                    }

                    if(isElementExist)
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        RemovePokemon(trainer);
                    }
                }
            }

            foreach (var trainer in Trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void RemovePokemon(Trainer trainer)
        {
            for (int i = 0; i < trainer.Pokemons.Count; i++)
            {
                trainer.Pokemons[i].Health -= 10;

                if (trainer.Pokemons[i].Health <= 0)
                {
                    trainer.Pokemons.Remove(trainer.Pokemons[i]);
                }
            }
        }
    }
}
