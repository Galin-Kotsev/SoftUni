using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern 
                = @"^[^\|\$\%\.]*\%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*\<(?<product>\w+)>[^\|\$\%\.]*\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";

            Regex  regex = new Regex(pattern);

            double income = 0;

            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {

                MatchCollection match = regex.Matches(input);

                foreach (Match order in match)
                {
                    string customer = order.Groups["customer"].Value;
                    string product = order.Groups["product"].Value;
                    int quantity = int.Parse(order.Groups["quantity"].Value);
                    double price = double.Parse(order.Groups["price"].Value);

                    double currPrice = quantity * price;
                    income += currPrice;

                    Console.WriteLine($"{customer}: {product} - {currPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
