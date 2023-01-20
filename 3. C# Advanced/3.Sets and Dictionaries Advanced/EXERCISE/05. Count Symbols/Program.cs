using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();

            Dictionary<char,int> symbolsCount 
                = new Dictionary<char,int>();

            foreach  (char letter in sentance)
            {
                if (!symbolsCount.ContainsKey(letter))
                {
                    symbolsCount.Add(letter, 1);
                }
                else
                {
                    symbolsCount[letter]++;
                }
            }

            foreach (var letter in symbolsCount.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
