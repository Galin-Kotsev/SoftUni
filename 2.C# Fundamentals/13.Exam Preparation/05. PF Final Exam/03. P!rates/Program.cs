using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var targets = new Dictionary<string, List<int>>();

            string input;

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputs = input.Split("||");

                string cities = inputs[0];
                int population = int.Parse(inputs[1]);
                int gold = int.Parse(inputs[2]);

                if (targets.ContainsKey(cities))
                {
                    targets[cities][0] += population;
                    targets[cities][1] += gold;
                }
                else
                {
                    targets.Add(cities, new List<int> { population, gold });
                } 
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split("=>");

                string command = inputs[0];
                string cities = inputs[1];

                if (command == "Plunder")
                {
                    int population = int.Parse(inputs[2]);
                    int gold = int.Parse(inputs[3]);

                    if (targets.ContainsKey(cities))
                    {
                        Console.WriteLine($"{cities} plundered! {gold} gold stolen, {population} citizens killed.");

                        targets[cities][0] -= population;
                        targets[cities][1] -= gold;

                        if (targets[cities][0] <= 0 || targets[cities][1] <= 0)
                        {
                            Console.WriteLine($"{cities} has been wiped off the map!");

                            targets.Remove(cities);
                        }
                    }
                }

                if (command == "Prosper")
                {
                    int gold = int.Parse(inputs[2]);

                    if (targets.ContainsKey(cities))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            targets[cities][1] += gold;

                            Console.WriteLine($"{gold} gold added to the city treasury. {cities} now has {targets[cities][1]} gold.");
                        }
                    }
                }
            }
            if (targets.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targets.Count} wealthy settlements to go to:");

                foreach (var city in targets)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
}
