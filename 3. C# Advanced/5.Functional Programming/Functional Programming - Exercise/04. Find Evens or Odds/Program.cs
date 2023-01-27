

using System;
using System.Collections.Generic;
using System.Linq;

int[] range = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string command = Console.ReadLine();

int start = range[0];
int end = range[1];

if (command == "odd")
{
    for (int i = start; i <= end; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"{i} ");
        }
    }
}
else if (command == "even")
{
    for (int i = start; i <= end; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}

