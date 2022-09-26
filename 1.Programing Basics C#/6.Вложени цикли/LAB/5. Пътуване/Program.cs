using System;

namespace _5._Пътуване
{
    class Program
    {
        static void Main(string[] args)
        {
            string destionation = Console.ReadLine();
            double  sum = 0;

            while ( destionation != "End")
            {

                double budget = double.Parse(Console.ReadLine());
                while (sum <= budget)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;

                    if (sum >= budget)
                    {
                        Console.WriteLine($"Going to {destionation}!");
                        sum = 0;
                        break;
                    }
                }

                destionation = Console.ReadLine();
            }
        }
    }
}
