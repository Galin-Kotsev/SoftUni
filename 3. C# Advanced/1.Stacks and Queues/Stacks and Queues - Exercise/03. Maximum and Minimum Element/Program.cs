﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] inputs = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int command = inputs[0];

                if (command == 1)
                {
                    int number = inputs[1];
                    stack.Push(number);
                }
                else if(command == 2)
                {
                    if(stack.Any())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command == 3)
                {
                    if(stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if(command == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
