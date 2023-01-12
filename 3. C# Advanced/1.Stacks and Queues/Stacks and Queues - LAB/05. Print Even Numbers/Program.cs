using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );

            List<int> result = new List<int>();

            while (queue.Count > 0)
            {
                int number = queue.Dequeue();

                if (number % 2 == 0)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
