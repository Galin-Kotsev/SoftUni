using System;
using System.Linq;

namespace _4._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] charecters = Console.ReadLine()
                .Split()
                .ToArray();


            for (int i = charecters.Length - 1; i >= 0; i--)
            {
                Console.Write($"{charecters[i]} ");
            }
        }
    }
}
