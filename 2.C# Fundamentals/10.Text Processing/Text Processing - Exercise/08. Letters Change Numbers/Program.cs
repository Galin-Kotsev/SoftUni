using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input
                = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double score = 0;

            foreach (var word in input)
            {
                char firstCh = word[0];
                char secondCh = word[word.Length - 1];
                double num = double.Parse(word.Substring(1, word.Length - 2));

                if (firstCh.ToString().ToUpper() == firstCh.ToString())
                {
                    score += num / (firstCh - 64);
                }
                else if (firstCh.ToString().ToLower() == firstCh.ToString())
                {
                    score += num * (firstCh - 96);
                }

                if (secondCh.ToString().ToUpper() == secondCh.ToString())
                {
                    score -= secondCh - 64;
                }
                else if (secondCh.ToString().ToLower() == secondCh.ToString())
                {
                    score += secondCh - 96;
                }

            }

            Console.WriteLine($"{score:f2}");

        }
    }
}
