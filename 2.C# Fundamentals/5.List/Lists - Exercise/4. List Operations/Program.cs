using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
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
            
            while (input != "End")
            {
                string[] inputs = input.Split();
                string command = inputs[0];
                string integer = inputs[1];

                if (command == "Add")
                {
                    numbers.Add(int.Parse(integer));
                }
                else if (command == "Remove")
                {
                    if (int.Parse(integer) >= 0 && int.Parse(integer) < numbers.Count)
                    {
                        numbers.RemoveAt(int.Parse(integer));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command == "Insert")
                {
                    if (int.Parse(inputs[2]) >= 0 && int.Parse(inputs[2]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(inputs[2]), int.Parse(integer));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (integer == "left")
                {
                    int couts = int.Parse(inputs[2]);

                    for (int i = 0; i < couts ; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                    
                }
                else if (integer == "right")
                {
                    int couts = int.Parse(inputs[2]);

                    for (int i = 0; i < couts; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
