using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> planetsAttacked = new List<string>();
            List<string> planetsDestoyed = new List<string>();

            string pattern 
                = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*!(?<action>[AD])![^@\-!:>]*->(?<soldiers>\d+)";
            
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                int count = 0;

                string decryptedMessage = string.Empty;


                string message = Console.ReadLine();

                foreach (char letter in message)
                {
                    if (letter == 's' || letter == 'a' || letter == 't' || letter == 'r' ||
                        letter == 'S' || letter == 'A' || letter == 'T' || letter == 'R')
                    {
                        count++;
                    }
                }

                foreach (char Letter in message)
                {
                    int currLetter = Letter - count;

                    decryptedMessage += (char)currLetter;
                }

                MatchCollection matches = regex.Matches(decryptedMessage);

                foreach (Match actions in matches)
                {
                    string planet = actions.Groups["planet"].Value;
                    string population = actions.Groups["population"].Value;
                    string action = actions.Groups["action"].Value;
                    string soldiers = actions.Groups["soldiers"].Value;

                    if (action == "A")
                    {
                        planetsAttacked.Add(planet);

                    }
                    else
                    {
                        planetsDestoyed.Add(planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {planetsAttacked.Count}");

            foreach (var planet in planetsAttacked.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {planetsDestoyed.Count}");

            foreach (var planet in planetsDestoyed.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        
    }
}
