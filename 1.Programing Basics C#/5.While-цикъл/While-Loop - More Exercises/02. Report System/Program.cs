using System;
using System.ComponentModel;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyNedded = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double sum = 0;
            double card = 0;
            double cardSum = 0;
            double cash = 0;
            double cashSum = 0;
            int count = 0;

            while (input != "End")
            {
                count++;
                double add = double.Parse(input);

                if (count%2==0)
                {
                    if (add < 10)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cardSum += add;
                        card++;
                    }
                }
                else
                {
                    if (add > 100)
                    {
                        Console.WriteLine($"Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine($"Product sold!");
                        cashSum += add;
                        cash++;
                    }   
                }

                sum = cashSum + cardSum;

                if (moneyNedded <= sum)
                {
                    break;
                }


                input = Console.ReadLine();
            }

            if (moneyNedded <= sum)
            {
                Console.WriteLine($"Average CS: {cashSum/cash:f2}");
                Console.WriteLine($"Average CC: {cardSum/card:f2}");
            }
            else
            {
                Console.WriteLine($"Failed to collect required money for charity.");
            }

        }
    }
}
