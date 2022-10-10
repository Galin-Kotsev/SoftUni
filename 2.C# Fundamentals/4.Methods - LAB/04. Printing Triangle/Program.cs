using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Print(n);
        }

        private static void Print(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                UpperPart(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                DownPart(i);
            }
        }

        private static void DownPart(int i)
        {
            for (int k = 1; k < i; k++)
            {
                Console.Write(k + " ");
            }

            Console.WriteLine(i);
        }

        private static void UpperPart(int i)
        {
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k + " ");
            }

            Console.WriteLine();
        }
    }
}
