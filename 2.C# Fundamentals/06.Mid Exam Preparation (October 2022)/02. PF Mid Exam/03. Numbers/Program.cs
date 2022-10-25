using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int avarage = (int)numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= avarage)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            numbers.Sort();
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            if (numbers.Count >= 5)
            {
                numbers = numbers.Take(5).ToList();
                Console.WriteLine(String.Join(" ", numbers));
            }
            else if (numbers.Count < 5)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
