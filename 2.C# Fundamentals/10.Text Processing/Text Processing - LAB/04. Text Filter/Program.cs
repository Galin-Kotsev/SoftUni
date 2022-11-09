using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bannedWord = Console.ReadLine().Split(", ").ToList();

            string sentance = Console.ReadLine();


            foreach (var word in bannedWord)
            {
                string oldWord = string.Empty;

                for (int i = 0; i < word.Length; i++)
                {
                    oldWord += "*";
                }

                sentance = sentance.Replace(word, oldWord);

            }

            Console.WriteLine(sentance);
           
        }
    }
}
