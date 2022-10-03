using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _06.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey1 = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            for (int currentElement = 0; currentElement < arrey1.Length; currentElement++)
            {
                int leftsum = 0;

                for (int i = 0; i < currentElement; i++)
                {
                    leftsum += arrey1[i];
                }

                int rightsum = 0;

                for (int i = currentElement + 1; i < arrey1.Length - 1; i++)
                {
                    rightsum += arrey1[i];
                }


            }
        }
    }
}
