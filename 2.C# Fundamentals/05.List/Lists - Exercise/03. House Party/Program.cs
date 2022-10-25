using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<String> guesList = new List<String>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                string action = input[2];

                if (action == "going!")
                {
                    if (guesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guesList.Add(name);
                    }
                    
                }
                else if (action == "not")
                {
                    if(!guesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guesList.Remove(name);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guesList));
        }
    }
}
