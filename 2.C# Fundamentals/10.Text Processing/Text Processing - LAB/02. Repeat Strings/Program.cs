using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string copyWord = string.Empty;

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    copyWord += word;
                }
            }

            Console.WriteLine(copyWord);
        }
    }
}
