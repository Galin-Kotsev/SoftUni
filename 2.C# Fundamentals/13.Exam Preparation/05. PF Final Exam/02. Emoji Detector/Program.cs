using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string pattern2 = @"(?<num>\d)";

            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern2);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            MatchCollection matches2 = regex2.Matches(input);

            BigInteger coolness = 1;

            foreach (Match num in matches2)
            {
                BigInteger number = BigInteger.Parse(num.Groups["num"].Value);

                coolness *= number;
            }

            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emojies in matches)
            {
                int emojieCoolness = 0;

                string currEmoji = emojies.Groups["emoji"].Value;

                for (int i = 0; i < currEmoji.Length; i++)
                {

                    emojieCoolness += currEmoji[i];
                }

                if (emojieCoolness >= coolness)
                {
                    Console.WriteLine(emojies);
                }
            }
        }
    }

}