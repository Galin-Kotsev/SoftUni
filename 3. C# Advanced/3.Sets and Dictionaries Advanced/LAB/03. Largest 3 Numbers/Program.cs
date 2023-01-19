using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            Console.WriteLine(string.Join(" ",numbers.Take(3)));

        }
    }
}
