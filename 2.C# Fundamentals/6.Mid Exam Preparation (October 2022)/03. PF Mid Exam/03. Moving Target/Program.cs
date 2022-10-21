using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputs = input.Split();
                string command = inputs[0];
                int index = int.Parse(inputs[1]);
                int value = int.Parse(inputs[2]);


                if (command == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                    
                }
                else if (command == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Strike")
                {
                    int radius = value;

                    if (index - value >= 0 && index + value < targets.Count)
                    {
                        targets.RemoveRange(index, radius);
                        targets.RemoveAt(index);
                        targets.RemoveRange(index - radius, radius);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        input = Console.ReadLine();
                        continue;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join("|", targets));
        }
    }
}
