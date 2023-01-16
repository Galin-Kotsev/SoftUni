using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(
                Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                );

            int rackcapacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int racks = 1;

            while (stack.Count > 0)
            {
                if (stack.Peek() + sum > rackcapacity)
                {
                    racks++;
                    sum = 0;
                    sum += stack.Pop();
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            Console.WriteLine(racks);
        }

    }
}