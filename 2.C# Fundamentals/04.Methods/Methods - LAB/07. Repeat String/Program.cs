using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());


            Console.WriteLine(WTF(word, repeats));
        }

        private static string WTF(string word, int repeats)
        {
            string result = string.Empty;

            for (int i = 0; i < repeats; i++)
            {
                result += word;
            }

            return result;
        }
    }
}
