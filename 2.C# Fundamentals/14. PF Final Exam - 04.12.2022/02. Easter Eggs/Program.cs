using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#]{1,})(?<color>[a-z]{3,})([@#]{1,})[\W]*(?<eggs>\d+)[\W]";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches.Cast<Match>())
            {
                string color = item.Groups["color"].Value;
                int eggs = int.Parse(item.Groups["eggs"].Value);

                Console.WriteLine($"You found {eggs} {color} eggs!");
            }
        }
    }
}
