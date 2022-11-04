using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sentance
                = new Dictionary<string, int>();

            string[] words = Console.ReadLine().ToLower().Split();

            foreach (var word in words)
            {
                if (sentance.ContainsKey(word))
                {
                    sentance[word]++;
                }
                else
                {
                    sentance.Add(word, 1);
                }
            }

            foreach (var (Key, Value) in sentance)
            {
                if (Value %2 != 0)
                {
                    Console.Write(Key + " ");
                }
            }
        }
    }
}

