using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int carsPassed = 0;

            Queue<string> cars = new Queue<string>();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count <= 0)
                        {
                            continue;
                        }
                        else
                        {
                            carsPassed++;
                            Console.WriteLine($"{cars.Peek()} passed!");
                            cars.Dequeue();
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
