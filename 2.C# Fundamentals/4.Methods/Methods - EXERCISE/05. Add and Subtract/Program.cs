using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int add = Add(a, b);
            int subtract = Subtract(add, c);

            Console.WriteLine(subtract);
        }

        private static int Subtract(int sum1, int c)
        {
            int sum2 = sum1 - c;

            return sum2;
        }

        private static int Add(int a, int b)
        {
            int sum1 = a + b;

            return sum1;

        }
    }
}
