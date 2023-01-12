using System;
using System.Collections.Generic;
using System.Threading;

namespace _7._Hot_Potato
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
                for (int i = 0; i < tosses; i++)
                {
                    

                }
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
