using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([#|])(?<item>[A-Za-z ]+)\1(?<expdate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,4})\1";

            int totalCalories = 0;

            Regex regex = new Regex(pattern);

            MatchCollection products = regex.Matches(input);

            foreach (Match product in products)
            {
                totalCalories += int.Parse(product.Groups["calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");

            foreach (Match item in products)
            {
                string product = item.Groups["item"].Value;
                string expDate = item.Groups["expdate"].Value;
                int calories = int.Parse(item.Groups["calories"].Value);

                Console.WriteLine($"Item: {product}, Best before: {expDate}, Nutrition: {calories}");
            }
        }

    }
}

