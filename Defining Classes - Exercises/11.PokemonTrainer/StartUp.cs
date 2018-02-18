using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        List<Trainer> trainers = new List<Trainer>();
        while (input!="Tournament")
        {
            var tokens = input.Split();
            var trainer = tokens[0];
            var pokemonName = tokens[1];
            var pokemonElement = tokens[2];
            var pokemonHealth = int.Parse(tokens[3]);
            if (!trainers.Any(t => t.Name == trainer))
            {
                trainers.Add(new Trainer(trainer));
            }
            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            Trainer trainerName = trainers.First(t => t.Name == trainer);
            trainerName.AddPokemon(pokemon);
            input = Console.ReadLine();
        }

        var command = Console.ReadLine();
        while (command!="End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemon.Any(e=>e.Element==command))
                {
                    trainer.IncreaseBadges();
                }
                else
                {
                    trainer.ReducePokemonsHealth();
                    trainer.RemoveDead();
                }
            }
            command = Console.ReadLine();
        }

        foreach (var trainer in trainers.OrderByDescending(b=>b.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemon.Count}");
        }
    }
}
