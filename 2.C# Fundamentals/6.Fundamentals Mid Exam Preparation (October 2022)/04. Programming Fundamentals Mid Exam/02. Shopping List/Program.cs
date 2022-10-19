using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split("!")
                .ToList();

            string input = Console.ReadLine();
             


            while (input != "Go Shopping!")
            {
                string[] inputs = input.Split();
                string command = inputs[0];
                string item = inputs[1];


                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {

                    if (groceries.Contains(item))
                    {
                        string item2 = inputs[2];

                        groceries[groceries.IndexOf(item)] = item2;
                    }
                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Add(item);
                        groceries.Remove(item);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}
