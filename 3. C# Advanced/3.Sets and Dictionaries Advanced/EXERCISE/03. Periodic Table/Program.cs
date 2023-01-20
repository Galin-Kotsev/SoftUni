using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n  = int.Parse(Console.ReadLine());

            HashSet<string> periodicElements
                = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(" ");

                for (int k = 0; k < elements.Length; k++)
                {
                    if (!periodicElements.Contains(elements[k]))
                    {
                        periodicElements.Add(elements[k]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", periodicElements.OrderBy(x=>x)));
        }
    }
}
