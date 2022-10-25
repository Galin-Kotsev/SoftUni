using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                

            List<int> numbers2 = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                List<int> reversed = numbers[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                numbers2.AddRange(reversed);
            }
            
            Console.WriteLine(String.Join(" ", numbers2));
        }
    }
}
