using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> costumerList = new Queue<string>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (costumerList.Count > 0)
                    {
                        Console.WriteLine(costumerList.Dequeue());
                    }
                    costumerList.Clear();
                }
                else
                {
                    costumerList.Enqueue(input);
                }
            }
            Console.WriteLine($"{costumerList.Count} people remaining.");
        }
    }
}
