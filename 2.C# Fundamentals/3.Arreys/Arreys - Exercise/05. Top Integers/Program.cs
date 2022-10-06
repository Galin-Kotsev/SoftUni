using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                bool bigNumber = true;

                for (int k = i+1; k < numbers.Length; k++)
                {
                    if (currNum <= numbers[k])
                    {
                        bigNumber = false;
                    }
                }

                if (bigNumber)
                {
                    Console.Write($"{currNum} ");
                }

            }
        }
    }
}
