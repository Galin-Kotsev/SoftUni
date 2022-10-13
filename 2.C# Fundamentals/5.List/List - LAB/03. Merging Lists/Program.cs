using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> numbers2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();


            List<int> newList = new List<int>();

            int size = Math.Min(numbers.Count, numbers2.Count);

            for (int i = 0; i < size; i++)
            {
                newList.Add(numbers[i]);
                newList.Add(numbers2[i]);
            }

            if (numbers.Count > numbers2.Count)
            {
                for (int i = size; i < numbers.Count; i++)
                {
                    newList.Add(numbers[i]);
                }
            }
            else
            {
                for (int i = size; i < numbers2.Count; i++)
                {
                    newList.Add(numbers2[i]);
                }
            }

            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
