using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfPassengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split();
                string command = inputs[0];

                if (command == "Add")
                {
                    numberOfPassengers.Add(int.Parse(inputs[1]));
                }
                else
                {
                    int passengers = int.Parse(command);

                    for (int i = 0; i < numberOfPassengers.Count; i++)
                    {
                        if (numberOfPassengers[i] + passengers <= capacity)
                        {
                            numberOfPassengers[i] += passengers;
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numberOfPassengers));
        }
    }
}
