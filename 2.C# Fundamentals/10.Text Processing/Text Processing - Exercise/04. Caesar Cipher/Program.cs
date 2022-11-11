using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();

            string encrypted = string.Empty;

            for (int i = 0; i < sentance.Length; i++)
            {
                encrypted += (char)(sentance[i] + 3);
            }

            Console.WriteLine(encrypted);
        }
    }
}
