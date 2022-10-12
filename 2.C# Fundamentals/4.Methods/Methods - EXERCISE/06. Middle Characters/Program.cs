using System;
using System.Dynamic;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            MiddleCharecterFinder(name);
        }

        private static void MiddleCharecterFinder(string name)
        {
            if (name.Length % 2 != 0)
            {
                Console.WriteLine(name[name.Length / 2]);
            }
            else
            {
                Console.WriteLine($"{name[name.Length / 2 - 1]}{name[name.Length / 2]}");
            }
        }
    }
}
