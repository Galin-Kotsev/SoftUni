using System;

namespace _5._Баланс_по_сметка
{
    class Program
    {
        static void Main(string[] args)
        {
            string increase = Console.ReadLine();
            double sum = 0;

            while (increase != "NoMoreMoney")
            {
                double added = double.Parse(increase);

                if (added < 0)
                {
                    Console.WriteLine("Invalid operation!");
                   break;
                }
                sum += added;
                Console.WriteLine($"Increase: {added:f2}");
                increase = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}

