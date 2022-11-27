using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            string pattern = @"([@#])(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            bool mirorWords = false;

            var matches = new Dictionary<string, string>();

            int pair = 0;

            Regex regex = new Regex(pattern);

            MatchCollection pairOfWords = regex.Matches(input);

            foreach (Match foundPair in pairOfWords)
            {
                pair++;
                string word1 = foundPair.Groups["word1"].Value;
                string word2 = foundPair.Groups["word2"].Value;
                string reverseWord = new string(word2.Reverse().ToArray());
                
                if (word1 == reverseWord)
                {
                    mirorWords = true;
                    matches.Add(word1, word2);
                }
            }

            if (pair == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{pair} word pairs found!");

                if (mirorWords)
                {
                    Console.WriteLine($"The mirror words are:");

                    StringBuilder stringBuilder = new StringBuilder();

                    foreach (var pairs in matches)
                    {
                        stringBuilder.Append($"{pairs.Key} <=> {pairs.Value}, ");
                    }
                    stringBuilder.Remove(stringBuilder.Length - 2, 2);

                    Console.WriteLine(stringBuilder);
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
                  
            }
        }
    }
}
