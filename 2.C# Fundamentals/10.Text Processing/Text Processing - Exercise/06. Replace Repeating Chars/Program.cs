using System;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {

                if (input[i] != input[i+1])
                {
                    output += input[i];
                }
            }
            output += input.Last();

            Console.WriteLine(output);  
        }
    }
}
