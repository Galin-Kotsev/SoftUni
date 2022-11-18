using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern 
            = @">>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            Regex  regex = new Regex(pattern);

            List<string> items = new List<string>(); 

            double totalPrice = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                MatchCollection match = regex.Matches(input);

                foreach (Match item in match)
                {
                    string furniture = item.Groups["furniture"].Value;
                    double price = double.Parse(item.Groups["price"].Value);
                    int quantity = int.Parse(item.Groups["quantity"].Value);

                    items.Add(furniture);

                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
