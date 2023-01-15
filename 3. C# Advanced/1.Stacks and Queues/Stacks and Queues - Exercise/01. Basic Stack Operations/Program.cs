using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray(); 

            Stack<int> stack = new Stack<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                );

            int s = inputs[1];
            int x = inputs[2];

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if(stack.Contains(x))
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
