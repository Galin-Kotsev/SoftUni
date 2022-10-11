using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            ActionCheck(action, a, b);

        }

        private static void ActionCheck(string action, int a, int b)
        {
            if (action == "+")
            {
                Add(a, b);
            }

            if (action == "-")
            {
                Substract(a, b);
            }

            if (action == "*")
            {
                Multiply(a, b);
            }

            if (action == "/")
            {
                Devide(a, b);
            }
        }

        private static void Devide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
