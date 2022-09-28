using System;
using System.Threading;

namespace _10._Clock___part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int a = 0; a <= 59; a++)
                {
                    for (int b = 0; b <= 59; b++)
                    {
                        Console.WriteLine($"{i} : {a} : {b}");
                    }
                }
            }
        }
    }    
}
