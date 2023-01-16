using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            string text 
                = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    
                int operation = int.Parse(inputs[0]);

                if (operation == 1)
                {
                    stack.Push(text);
                    text += inputs[1];
                }
                else if (operation == 2)
                {
                    stack.Push(text);
                    int index = int.Parse(inputs[1]);
                    text = text.Remove(text.Length - index);
                }
                else if (operation == 3)
                {
                    int index = int.Parse(inputs[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else if (operation == 4)
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
