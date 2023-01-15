using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int foodCapacity = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine()
                .Split(" ")
                .Select(int.Parse));

            int biggestOrder = 0;

            while (orders.Count > 0)
            {
                if (orders.Peek() > biggestOrder)
                {
                    biggestOrder = orders.Peek();
                }

                if (orders.Peek() <= foodCapacity)
                {
                    foodCapacity -= orders.Peek();
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (orders.Any())
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
            else
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
