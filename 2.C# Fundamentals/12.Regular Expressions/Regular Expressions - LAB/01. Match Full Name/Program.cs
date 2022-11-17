using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = @"\b[A-Z][a-z]+\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(code);

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
