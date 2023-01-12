using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(
                Console.ReadLine()
                .Split(" " ,StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                );

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string action = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (action == "+")
                {
                    stack.Push((second+first).ToString());
                }
                else
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
