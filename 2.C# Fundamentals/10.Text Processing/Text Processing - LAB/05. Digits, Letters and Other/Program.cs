using System;

namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentance = Console.ReadLine();

            string digit = string.Empty;
            string letter = string.Empty;
            string symbol = string.Empty;

            for (int i = 0; i < sentance.Length; i++)
            {
                if (char.IsLetter(sentance[i]))
                {
                    letter += sentance[i];
                }
                else if (char.IsDigit(sentance[i]))
                {
                   digit += sentance[i];
                }
                else 
                {
                    symbol += sentance[i];
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(symbol);
        }
    }
}
