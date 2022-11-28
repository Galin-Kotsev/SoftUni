using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"(@#+)(?<product>[A-Z][A-Za-z\d]{4,}[A-Z])(@#+)";
            string pattern2 = @"(?<digits>\d)";

            Regex regex = new Regex(pattern);
            Regex regex2 = new Regex(pattern2);

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                bool invalid = true;

                MatchCollection matches = regex.Matches(input);
                MatchCollection matches2 = regex2.Matches(input);
                string newDigit = string.Empty;
                bool containDigit = false;

                foreach (Match match in matches)
                {
                    invalid = false;

                    foreach (Match digit in matches2)
                    {
                        string digits = digit.Groups["digits"].Value;

                        for (int k = 0; k < digits.Length; k++)
                        {
                            if (digit.Length >= 0)
                            {
                                containDigit = true;
                                newDigit += digits[k]; 
                            }
                        }
                    }
                }

                if (!invalid)
                {
                    if (containDigit)
                    {
                        Console.WriteLine($"Product group: {newDigit}");
                    }
                    else
                    {
                        newDigit = "00";
                        Console.WriteLine($"Product group: {newDigit}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
