using System;

namespace _4.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double toys = 0;
            int money = 0;
            int counter = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i%2 == 0)
                {
                    money += 10 * counter -1;
                    counter++;
                }
                else
                {
                    toys++;
                }
            }
            double totalMoney = (toys * toyPrice) + money;
            if (totalMoney >= washer)
            {
                Console.WriteLine($"Yes! {totalMoney-washer:f2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(totalMoney - washer):f2}");
            }
                
        }
    }
}
