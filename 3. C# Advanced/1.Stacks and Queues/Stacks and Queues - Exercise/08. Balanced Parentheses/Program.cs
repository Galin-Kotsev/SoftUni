using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenteses = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char parentes in parenteses)
            {
                if (parentes == '(' || parentes == '[' || parentes == '{')
                {
                    stack.Push(parentes);
                }
                else
                {
                    if (parentes == ')')
                    {
                        if(stack.Count == 0 || stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (parentes == ']')
                    {
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (parentes == '}')
                    {
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
                Console.WriteLine("YES");
        }
    }
}
