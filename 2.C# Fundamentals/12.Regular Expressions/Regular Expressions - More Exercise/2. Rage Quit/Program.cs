using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letterPattern = @"([^\d]+)";
            string digitsPattern = @"([\d]+)";
            List<char> unique = new List<char>();

            Regex letter = new Regex(letterPattern);
            Regex digit = new Regex(digitsPattern);

            string input = Console.ReadLine().ToUpper();

            MatchCollection letters = letter.Matches(input);
            MatchCollection digits = digit.Matches(input);

            string result = string.Empty;

            if (letters.Any())
            {
                if (digits.Any())
                {
                    for (int i = 0; i < letters.Count; i++)
                    {
                        string charecter = letters[i].Value;
                        int n = int.Parse(digits[i].Value);

                        for (int l = 0; l < charecter.Length; l++)
                        {
                            if (!unique.Contains(charecter[l]))
                            {
                                unique.Add(charecter[l]);
                            }
                        }

                        for (int k = 1; k <= n; k++)
                        {
                            result += charecter.ToString();
                        }
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {unique.Count}");
            Console.WriteLine(result);
        }
    }
}
