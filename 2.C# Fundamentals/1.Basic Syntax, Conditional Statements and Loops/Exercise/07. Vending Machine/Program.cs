using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double coinsSum = 0;
            string input = Console.ReadLine();

            while (input != "Start")
            {
                AddMoney(ref coinsSum, ref input);

            }

            string order = Console.ReadLine();

            while (order != "End")
            {
                Order(ref coinsSum, ref order);
            }

            Console.WriteLine($"Change: {coinsSum:f2}");


        }

        private static void Order(ref double coinsSum, ref string order)
        {
            if (order == "Nuts")
            {
                if (coinsSum >= 2)
                {
                    coinsSum -= 2;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (order == "Water")
            {
                if (coinsSum >= 0.7)
                {
                    coinsSum -= 0.7;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (order == "Crisps")
            {
                if (coinsSum >= 1.5)
                {
                    coinsSum -= 1.5;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (order == "Soda")
            {
                if (coinsSum >= 0.8)
                {
                    coinsSum -= 0.8;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else if (order == "Coke")
            {
                if (coinsSum >= 1)
                {
                    coinsSum -= 1;
                    Console.WriteLine($"Purchased {order.ToLower()}");
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }

            order = Console.ReadLine();
        }

        private static void AddMoney(ref double coinsSum, ref string input)
        {
            double coin = double.Parse(input);

            if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
            {
                coinsSum += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }

            input = Console.ReadLine();
        }
    }
}
