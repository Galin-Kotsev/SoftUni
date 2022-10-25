using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passenger = int.Parse(Console.ReadLine());

            int[] lifts = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool full = false;

            for (int i = 0; i < lifts.Length; i++)
            {
                while (lifts[i] < 4 && passenger > 0)
                {
                    lifts[i]++;
                    passenger--;
                }

                if (lifts[lifts.Length - 1] == 4)
                {
                    full = true;
                }
            }

            if (passenger > 0 && full)
            {
                Console.WriteLine($"There isn't enough space! {passenger} people in a queue!");
                Console.WriteLine(String.Join(" ", lifts));

            }
            else if (passenger == 0 && !full)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", lifts));
            }
            else if (passenger == 0 && full)
            {
                Console.WriteLine(String.Join(" ", lifts));
            }

        }
    }
}
