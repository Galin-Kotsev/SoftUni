using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            double quantity = int.Parse(Console.ReadLine());

            OrderCheck(order, quantity);
        }

        private static void OrderCheck(string order, double quantity)
        {
            if (order == "coffee")
            {
                Console.WriteLine($"{quantity * 1.50:f2}");
            }
            else if (order == "water")
            {
                Console.WriteLine($"{quantity * 1:f2}");
            }
            else if (order == "coke")
            {
                Console.WriteLine($"{quantity * 1.4:f2}");
            }
            else if (order == "snacks")
            {
                Console.WriteLine($"{quantity * 2:f2}");
            }
        }
    }
}
