using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();
            var plantRaritie = new Dictionary<string, double>();

            string input;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] inputs = input.Split("<->");

                string plant = inputs[0];
                double rarity = double.Parse(inputs[1]);

                if (!plantRaritie.ContainsKey(plant))
                {
                    plantRaritie.Add(plant, rarity);
                    plantRating.Add(plant, new List<double> ());
                }
                else
                {
                    plantRaritie[plant] = rarity;
                }

            }

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] inputs = input.Split(new char[] { ' ', ':', '-'}, StringSplitOptions.RemoveEmptyEntries);

                string command = inputs[0];
                
                string plant = inputs[1];

                if (command == "Rate")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        double rating = double.Parse(inputs[2]);

                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                if (command == "Update")
                {
                    double rarity = double.Parse(inputs[2]);

                    if (plantRaritie.ContainsKey(plant))
                    {
                        plantRaritie[plant] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                if (command == "Reset")
                {
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var (plant,rarity) in plantRaritie)
            {
                if (plantRating[plant].Count > 0)
                {
                    double plantAverage = plantRating[plant].Average();

                    Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {plantAverage:f2}");
                }
                else
                {
                    Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {0:f2}");
                }
            }
        }
    }
}
