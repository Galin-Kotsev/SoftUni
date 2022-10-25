using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split();
                string command = inputs[0];

                if (command == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(inputs[1]));
                }
                else if (command == "Insert")
                {
                    numbers.Insert(int.Parse(inputs[2]), int.Parse(inputs[1]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
