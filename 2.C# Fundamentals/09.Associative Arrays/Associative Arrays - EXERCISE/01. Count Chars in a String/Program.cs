using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!words.ContainsKey(ch))
                    {
                        words[ch] = 0;
                    }

                    words[ch]++;
                }
            }

            foreach (var (Key, Value) in words)
            {
                Console.WriteLine($"{Key} -> {Value}");
            }
            
        }
    }
}
