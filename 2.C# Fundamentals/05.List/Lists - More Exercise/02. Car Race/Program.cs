using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            double rightRacer = 0;
            double leftRacer = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                left.Add(numbers[i]);
            }

            for (int p = numbers.Count / 2 + 1; p < numbers.Count; p++)
            {
                right.Add(numbers[p]);
            }

            for (int k = 0; k < left.Count; k++)
            {
                if (left[k] == 0)
                {
                    leftRacer *= 0.8;
                }

                leftRacer += left[k];
            }

            right.Reverse();

            for (int l = 0; l < right.Count; l++)
            {
                if (right[l] == 0)
                {
                    rightRacer *= 0.8;
                }

                rightRacer += right[l];
            }

            if (leftRacer < rightRacer)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightRacer}");
            }
        }
    }
}
