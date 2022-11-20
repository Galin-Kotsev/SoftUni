using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //why did you make me write the pattern !!!
            
            string pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input); 

            foreach (Match mail in matches)
            {
                Console.WriteLine(mail);
            }
        }
    }
}
