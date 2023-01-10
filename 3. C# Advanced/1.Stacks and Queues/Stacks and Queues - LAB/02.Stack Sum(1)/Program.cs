using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers
                = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack
                = new Stack<int>(numbers);

            string input;

            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] inputs = input.Split();
                string command = inputs[0];

                if (command == "add")
                {
                    int firstAdd = int.Parse(inputs[1]);
                    int secondAdd = int.Parse(inputs[2]);

                    stack.Push(firstAdd);
                    stack.Push(secondAdd);
                }
                else if (command == "remove")
                {
                    int n = int.Parse(inputs[1]);

                    if (n < stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

