using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] newAdd = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = newAdd[0];
                int secondNum = newAdd[1];

                if (i % 2 == 0)
                {
                    a[i] = firstNum;
                    b[i] = secondNum;
                }
                else
                {
                    b[i] = firstNum;
                    a[i] = secondNum;
                }
            }

            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine(String.Join(" ", b));
        }
    }
}