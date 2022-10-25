using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bomb = input[0];
            int power = input[1];


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        if (j < 0)
                        {
                            j = 0;
                        }
                        if (j > numbers.Count - 1)
                        {
                            break;
                        }
                        numbers[j] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
