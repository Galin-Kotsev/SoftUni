using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents
                = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokents = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = tokents[0];
                string country = tokents[1];
                string city = tokents[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                    continents[continent][country].Add(city);
            }

            foreach (var continentName in continents)
            {
                Console.WriteLine($"{continentName.Key}:");

                foreach (var countrieName in continentName.Value)
                {
                    Console.WriteLine($"  {countrieName.Key} -> {string.Join(", ", countrieName.Value)}");
                }
            }
        }
    }
}
