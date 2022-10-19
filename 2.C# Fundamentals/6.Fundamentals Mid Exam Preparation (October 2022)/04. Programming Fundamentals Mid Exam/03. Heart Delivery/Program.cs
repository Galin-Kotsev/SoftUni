using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> heartsInHouse = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            int position = 0;

            while (command != "Love!")
            {
                string[] inpust = command.Split();
                int jumps = int.Parse(inpust[1]);

                if (position + jumps < heartsInHouse.Count)
                {
                    position += jumps;
                }
                else
                {
                    position = 0;
                }

                heartsInHouse[position] -= 2;

                if (heartsInHouse[position] == 0)
                {
                    Console.WriteLine($"Place {position} has Valentine's day.");
                    heartsInHouse[position] = -1;
                }
                else if (heartsInHouse[position] < 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }

            int fail = 0;
            for (int i = 0; i < heartsInHouse.Count; i++)
            {
                if (heartsInHouse[i] > 0)
                {
                    fail++;
                }
            }

            Console.WriteLine($"Cupid's last position was {position}.");
            if (fail == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {fail} places.");
            }

        }


    }
}

