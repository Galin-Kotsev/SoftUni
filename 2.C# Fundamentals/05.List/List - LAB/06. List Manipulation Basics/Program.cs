using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
                int parameter = int.Parse(inputs[1]);
                CommandExecute(numbers, inputs, command, parameter);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CommandExecute(List<int> numbers, string[] inputs, string command, int parameter)
        {
            if (command == "Add")
            {
                numbers.Add(parameter);
            }
            else if (command == "Remove")
            {
                numbers.Remove(parameter);
            }
            else if (command == "RemoveAt")
            {
                numbers.RemoveAt(parameter);
            }
            else if (command == "Insert")
            {
                int index = int.Parse(inputs[2]);
                numbers.Insert(index, parameter);
            }
        }
    }
}
