using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternName = @"([@|])(?<name>(\w+))([@|])";
            string patternAge = @"([#*])(?<age>(\d+))([#*])";

            Regex nameRegex = new Regex(patternName);
            Regex ageRegex = new Regex(patternAge);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match matchName = nameRegex.Match(input);
                Match matchAge = ageRegex.Match(input);

                string name = String.Empty;
                int age = 0;

                if (matchAge.Success)
                {
                    string nameMatch = matchName.Groups["name"].Value;
                    name = nameMatch;
                }

                if(matchAge.Success)
                {
                    int ageMatch = int.Parse(matchAge.Groups["age"].Value);
                    age = ageMatch;

                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
