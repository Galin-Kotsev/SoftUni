using System;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
