using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string places = Console.ReadLine();

            string pattern = @"([=\/])(?<destination>[A-Z][A-Za-z]{2,})\1";

            Regex regex = new Regex(pattern);

            int points = 0;

            List <string> locationsList =new List<string>();

            MatchCollection destination = regex.Matches(places);

            foreach (Match locations in destination)
            {
                string location = locations.Groups["destination"].Value;

                locationsList.Add(location);

                points += location.Length;
            }

            Console.Write($"Destinations: ");
            Console.WriteLine(string.Join(", ", locationsList));
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
