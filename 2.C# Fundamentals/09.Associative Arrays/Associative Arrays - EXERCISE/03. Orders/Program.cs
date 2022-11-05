using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();
              
            while (input != "buy")
            {
                string[] inputs = input.Split();   
                
                string item = inputs[0];
                double price = double.Parse(inputs[1]);
                double quantity = double.Parse(inputs[2]);

                if (!items.ContainsKey(item))
                {
                    items.Add(item, new List<double>() { price, quantity });
                }
                else
                {
                    items[item][0] = price;
                    items[item][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var (Key, Value) in items)
            {
                Console.WriteLine($"{Key} -> {Value[0] * Value[1]:f2}");
            }
        }
    }
}
