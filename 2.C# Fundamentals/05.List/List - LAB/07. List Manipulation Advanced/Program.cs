using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            bool changes = false;

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputs = input.Split();
                string command = inputs[0];
                

                if (command == "Add")
                {
                    string parameter = (inputs[1]);
                    numbers.Add(int.Parse(parameter));
                    changes = true;
                }
                else if (command == "Remove")
                {
                    string parameter = (inputs[1]);
                    numbers.Remove(int.Parse(parameter));
                    changes = true;
                }
                else if (command == "RemoveAt")
                {
                    string parameter = (inputs[1]);
                    numbers.RemoveAt(int.Parse(parameter));
                    changes = true;
                }
                else if (command == "Insert")
                {
                    string parameter = (inputs[1]);
                    int index = int.Parse(inputs[2]);
                    numbers.Insert(index, int.Parse(parameter));
                    changes = true;
                }
                else if (command == "Contains")
                {    
                    string parameter = (inputs[1]);

                    if (numbers.Contains(int.Parse(parameter)))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0).ToList()));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0).ToList()));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string parameter = (inputs[1]);
                    string operatoration = parameter;
                    int num = int.Parse(inputs[2]);

                    if (operatoration == ">")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x > num).ToList()));
                    }
                    else if (operatoration == "<")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x < num).ToList()));
                    }
                    else if (operatoration == "<=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x <= num).ToList()));
                    }
                    else if (operatoration == ">=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.Where(x => x >= num).ToList()));
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(changes? string.Join(" ", numbers): null);

        }
    }
}
