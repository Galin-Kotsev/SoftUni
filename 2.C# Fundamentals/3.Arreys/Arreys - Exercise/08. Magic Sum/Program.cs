using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey1 = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            int specialNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrey1.Length; i++)
            {
                for (int k = i + 1; k < arrey1.Length; k++)
                {
                    if (arrey1[i] + arrey1[k] == specialNumber)
                    {
                        Console.WriteLine($"{arrey1[i]} {arrey1[k]}");
                    }
                }
            }
        }
    }
}

