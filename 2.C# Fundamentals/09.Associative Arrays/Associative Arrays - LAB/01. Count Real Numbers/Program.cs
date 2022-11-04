using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary <double, int> numbers 
                = new SortedDictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in input)
            {
                if (!numbers.ContainsKey(number)) 
                {
                    numbers.Add(number, 0);        
                }

                numbers[number] += 1;

            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
