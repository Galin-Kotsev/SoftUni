using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine());
            int twoLev = int.Parse(Console.ReadLine());
            int fiveLev = int.Parse(Console.ReadLine());
            int moneySum = int.Parse(Console.ReadLine());



            for (int i = 0; i <= oneLev; i++)
            {
                for (int g = 0; g <= twoLev; g++)
                {
                    for (int h = 0; h <= fiveLev; h++)
                    {
                        if (i * 1 + g * 2 + h * 5 == moneySum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {g} * 2 lv. + {h} * 5 lv. = {moneySum} lv.");
                        }
                    }
                }
            }
        }
    }
}
