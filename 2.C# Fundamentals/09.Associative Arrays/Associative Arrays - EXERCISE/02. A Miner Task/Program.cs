using System;
using System.Collections.Generic;
using System.Threading;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                if (!mine.ContainsKey(input))
                {
                    mine.Add(input, 0);
                }

                int quantity = int.Parse(Console.ReadLine());
                mine[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var (Key, Value) in mine)
            {
                Console.WriteLine($"{Key} -> {Value}");
            }
        }

    }
}
