using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = @"\+\b359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(code);

            MatchCollection matches = regex.Matches(input);

            Console.Write(string.Join(", ", matches));
        }
    }
}
