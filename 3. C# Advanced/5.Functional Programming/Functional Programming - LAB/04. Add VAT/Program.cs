using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {// First Solution :D

            Func<double, double> addVat 
                = x => x * 1.20;

            Console.ReadLine()
                 .Split(", ")
                 .Select(double.Parse)
                 .Select(x => addVat(x))
                 .ToList().ForEach(x => Console.WriteLine($"{x:F2}"));

            // Second Solution :D

            double[] nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            double[] numsPlusVat = nums.Select(x => addVat(x)).ToArray();

            Array.ForEach(numsPlusVat, x => Console.WriteLine($"{x:f2}"));
        }
    }
}
