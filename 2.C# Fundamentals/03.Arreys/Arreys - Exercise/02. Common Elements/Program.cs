using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split().ToArray();

            string[] b = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < b.Length; i++)
            {
                for (int k = 0; k < a.Length; k++)
                {
                    if (b[i] == a[k])
                    {
                        Console.Write($"{b[i]} ");
                    }
                }
            }

        }
    }
}
