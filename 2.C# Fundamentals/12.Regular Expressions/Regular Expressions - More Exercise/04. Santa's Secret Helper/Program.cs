using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = @"[@](?<kidName>[A-Za-z]+)[^\@\-\!\:\>]*(?<behavior>!G!)";

            int n = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string decrypteMessage = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    decrypteMessage += char.Parse(((char)(input[i] - n)).ToString());
                }

                Regex regex = new Regex(name);

                Match matchName = regex.Match(decrypteMessage);

                if (matchName.Success)
                {
                    string kidName = string.Empty;
                    kidName = matchName.Groups["kidName"].Value;
                    Console.WriteLine(kidName);
                }
            }
        }
    }
}
