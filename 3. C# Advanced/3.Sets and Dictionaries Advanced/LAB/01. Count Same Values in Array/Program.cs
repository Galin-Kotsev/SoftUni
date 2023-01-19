using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> numbers = new Dictionary<double,int>();

            for (int i = 0; i < inputs.Length; i++)
            {
                if (!numbers.ContainsKey(inputs[i]))
                {
                    numbers.Add(inputs[i], 1);
                }
                else
                {
                    numbers[inputs[i]]++;
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
