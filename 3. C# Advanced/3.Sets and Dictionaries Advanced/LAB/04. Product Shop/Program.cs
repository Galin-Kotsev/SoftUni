using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, double>> marketName 
                = new Dictionary<string, Dictionary<string, double>>();

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokents = input
                .Split(", ");

                string market = tokents[0];
                string product = tokents[1];
                double price = double.Parse(tokents[2]);

                if (!marketName.ContainsKey(market))
                {
                    marketName.Add(market, new Dictionary<string, double>());
                }

                marketName[market].Add(product, price);
            }

            foreach (var markedPlace in marketName.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{markedPlace.Key}->");

                foreach (var product in markedPlace.Value) 
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
