using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> keys
                = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string orePattern = @"([\&])(?<ore>\w*)\1";
            string locationPattern = @"[<](?<location>\w*)[>]";

            Regex regex = new Regex(orePattern);
            Regex regex1 = new Regex(locationPattern);

            string message;

            var treasure
                = new Dictionary<string, string>();

            while ((message = Console.ReadLine()) != "find")
            {
                string decryptedMessage = string.Empty;

                for (int i = 0; i < message.Length; i++)
                {
                    if (i >= keys.Count)
                    {
                        keys.AddRange(keys);
                    }

                    decryptedMessage += (char)(message[i] - keys[i]);
                }

                Match ore = regex.Match(decryptedMessage);
                Match location = regex1.Match(decryptedMessage);

                if (ore.Success && location.Success)
                {
                    string ores = ore.Groups["ore"].Value;
                    string locations = location.Groups["location"].Value;

                    treasure.Add(ores, locations);
                }
            }

            foreach (var (Key, Value) in treasure)
            {
                Console.WriteLine($"Found {Key} at {Value}");
            }

        }
    }
}
