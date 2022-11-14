using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target =
                Console.ReadLine();

            string newWord = string.Empty;

            int power = 0;


            for (int i = 0; i < target.Length; i++)
            {
                if (char.IsSymbol(target[i]))
                {
                    power += int.Parse(target[i+1].ToString()) + 1;

                    newWord += target[i];
                }

                if (power == 0)
                {
                    newWord += target[i];
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(newWord);
        }
    }
}
