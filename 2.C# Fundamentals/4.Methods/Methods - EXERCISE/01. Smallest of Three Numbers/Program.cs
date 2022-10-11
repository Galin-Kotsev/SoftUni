using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Compares(a, b, c));
        }

        private static int Compares(int a, int b, int c)
        {
            int smallest = 0;

            if (a < b && a < c)
            {
                smallest = a;
            }
            else if (b < c && b < a)
            {
                smallest = b;
            }
            else if (c <= b && c <= a)
            {
                smallest = c;
            }

            return smallest;
        }
    }
}
