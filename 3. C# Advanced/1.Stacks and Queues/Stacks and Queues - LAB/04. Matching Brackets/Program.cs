using System;
using System.Collections.Generic;
using System.IO;

namespace _04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string sentance = Console.ReadLine();

            Stack<int> stack 
                = new Stack<int>();


            for (int i = 0; i < sentance.Length; i++)
            {

                if (sentance[i] == '(')
                {
                    stack.Push(i);
                }

                if (sentance[i] == ')')
                {
                    int index = stack.Pop();
                    Console.WriteLine(sentance.Substring(index, i - index + 1));
                }
            }
        }
    }
}
