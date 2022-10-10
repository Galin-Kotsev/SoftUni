using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            ActionCheck(action, a, b);

        }

        private static void ActionCheck(string action, int a, int b)
        {
            if (action == "add")
            {
                Add(a, b);
            }

            if (action == "subtract")
            {
                Substract(a, b);
            }

            if (action == "multiply")
            {
                Multiply(a, b);
            }

            if (action == "divide")
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
