using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _03.Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            int count = 0;

            while (input != "end")
            {
                string[] inputs = input.Split(" ");
                int index1 = int.Parse(inputs[0]);
                int index2 = int.Parse(inputs[1]);

                count++;

                if (!(index1 >= 0 && index1 < numbers.Count && index2 >= 0 && index2 < numbers.Count && index1 != index2))
                {
                    numbers.Insert(numbers.Count / 2, ($"-{count}a"));
                    numbers.Insert(numbers.Count / 2, ($"-{count}a"));

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (numbers[index1] == numbers[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[index1]}!");
                    numbers.RemoveAt(index1);
                    if (index1 < index2)
                    {
                        numbers.RemoveAt(index2 - 1);
                    }
                    else
                    {
                        numbers.RemoveAt(index2);
                    }
                }
                else if (!(numbers[index1] == numbers[index2]))
                {
                    Console.WriteLine($"Try again!");
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
