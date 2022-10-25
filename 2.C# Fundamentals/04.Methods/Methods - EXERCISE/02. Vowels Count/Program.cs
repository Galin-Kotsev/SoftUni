using System;
using System.Security.Cryptography.X509Certificates;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(Compare(input)); 
        }

        private static int Compare(string input)
        {
            int vowelsCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // a, e, i, o, and u.
                char a = input[i];

                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
