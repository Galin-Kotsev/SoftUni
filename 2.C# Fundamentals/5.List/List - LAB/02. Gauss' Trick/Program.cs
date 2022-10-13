using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> numbers2 = new List<int>();
            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers2.Add(numbers[i] + numbers[numbers.Count - i - 1]);
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers2.Add(numbers[i] + numbers[numbers.Count - i - 1]);
                }
                numbers2.Add(numbers[numbers.Count / 2 ]);
            }
           
            Console.WriteLine(String.Join(" ", numbers2));  
        }
    }
}
