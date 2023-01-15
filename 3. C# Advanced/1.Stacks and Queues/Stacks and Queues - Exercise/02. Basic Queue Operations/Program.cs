using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> stack = new Queue<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                );

            int s = inputs[1];
            int x = inputs[2];

            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count <= 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
