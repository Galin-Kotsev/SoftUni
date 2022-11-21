using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> demons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<double>> score = new Dictionary<string, List<double>>();

            string pattern = @"-?\d+\.?\d*";

            Regex regex = new Regex(pattern);

            foreach (var demon in demons)
            {
                int health = 0;
                double damage = 0;

                foreach (char ch in demon)
                {
                    if (char.IsLetter(ch))
                    {
                        health += ch;
                    }
                }

                MatchCollection match = regex.Matches(demon);

                foreach (Match item in match)
                {
                    damage += double.Parse(item.Value);
                }

                foreach (char ch in demon)
                {
                    if (ch == '*')
                    {
                        damage *= 2;
                    }
                    else if (ch == '/')
                    {
                        damage /= 2;
                    }
                }

                score.Add(demon.Trim(), new List<double>());
                score[demon.Trim()].Add(health);
                score[demon.Trim()].Add(damage);
            }

            foreach (var demon in score.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage ");
            }

        }
    }
}


