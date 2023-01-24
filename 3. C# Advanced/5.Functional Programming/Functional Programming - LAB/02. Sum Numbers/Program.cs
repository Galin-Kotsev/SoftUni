using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            Console.WriteLine(number.Length);
            Console.WriteLine(number.Sum());
        }
    }
}
