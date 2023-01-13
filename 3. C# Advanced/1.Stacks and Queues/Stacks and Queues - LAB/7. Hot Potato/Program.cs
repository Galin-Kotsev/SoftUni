using System;
using System.Collections.Generic;
using System.Threading;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(
                Console.ReadLine()
                .Split(" "));

            int tosses 
                = int.Parse(Console.ReadLine());

            while (players.Count != 1)
            {
                for (int i = 1 ; i <= tosses; i++)
                {
                    if(tosses == i)
                    {
                        Console.WriteLine($"Removed {players.Peek()}");
                        players.Dequeue();
                    }
                    else
                    {
                        string name = players.Dequeue();
                        players.Enqueue(name);
                    }
                }
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}
