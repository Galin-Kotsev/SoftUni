using Microsoft.VisualBasic;
using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();

            string sentance = string.Empty;

            bool n = false;
            bool o = false;
            bool c = false;


            while (letter != "End")
            {
                char add = char.Parse(letter);

                if (letter == "c" && c == false)
                {
                    c = true;
                }
                else if (letter == "o" &&  o == false)
                {
                    o  = true; 
                }
                else if (letter == "n" && n == false)
                {
                    n = true;
                }
                else if ((add > 64 && add < 91) || (add > 96 && add < 123))
                {
                    sentance += add;
                }

                if (c  && o  && n)
                { 

                    Console.WriteLine($"{sentance}" + " ");
                    c = false;
                    o = false;
                    n = false;
                    sentance = string.Empty;

                }


                letter = Console.ReadLine();
            }

        }
    }
}
