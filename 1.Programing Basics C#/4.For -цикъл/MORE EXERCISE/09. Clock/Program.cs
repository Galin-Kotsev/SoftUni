using System;

namespace _09._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int a = 0; a <= 59; a++)
                {

                    Console.WriteLine($"{i} : {a}");

                }
            }
        }
    }
}
