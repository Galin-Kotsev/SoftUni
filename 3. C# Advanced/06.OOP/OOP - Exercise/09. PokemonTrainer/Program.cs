namespace _09._PokemonTrainer;

public class StartUp
{
    public static void Main()
    {
        List<Trainer> trainers 
            = new List<Trainer>();

        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] inputs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = inputs[0];
            string pokemonName = inputs[1];
            string element = inputs[2];
            int health = int.Parse(inputs[3]);

            if (!trainers.Any(x=> x.Name == name))
            {
                trainers.Add(new Trainer(name));
            }

            trainers.FirstOrDefault(x => x.Name == name)
                .Pokemons.Add(new Pokemon(pokemonName, element, health));
        }

        while ((input = Console.ReadLine()) != "End")
        {
            string element = input;

            foreach (var trainer in trainers)
            {
                bool fightWon = false;

                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Element == element)
                    {
                        fightWon = true;
                        continue;
                    }
                }

                if (fightWon)
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.Remove(trainer.Pokemons[i]);
                            i--;
                        }
                        else
                        {
                            trainer.Pokemons[i].Health -= 10;
                        }
                    }

                }
            }
        }

        foreach (Trainer trainer in trainers.OrderByDescending(x=>x.NumberOfBadges)) 
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
        
        }
    }
}
