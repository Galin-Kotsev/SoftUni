using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code 
                = @"(?<day>\d{2})([-|.|\/])(?<month>[A-Z][a-z]+)\1(?<year>\d{4})";

            Regex  regex = new Regex(code);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (Match item in matches)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;


                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}


