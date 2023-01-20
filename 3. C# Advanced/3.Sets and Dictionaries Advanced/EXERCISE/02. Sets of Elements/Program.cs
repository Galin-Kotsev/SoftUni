using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int n1 = size[0];
            int n2 = size[1];

            HashSet<int> set1
                = new HashSet<int>();

            HashSet<int> set2
                = new HashSet<int>();

            for (int i = 0; i < n1 + n2; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < n1)
                {
                    set1.Add(number);
                }
                else
                {
                    set2.Add(number);
                }
            }

            set1.IntersectWith(set2);

            Console.WriteLine(string.Join(" ", set1));
        }
    }
}
