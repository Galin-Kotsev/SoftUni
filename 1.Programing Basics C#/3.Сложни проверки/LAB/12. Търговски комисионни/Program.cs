using System;

namespace _12._Търговски_комисионни
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.05;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales >500  && sales <= 1000)
                {
                    sales *= 0.07;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.08;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 10000)
                {
                    sales *= 0.12;
                    Console.WriteLine($"{sales:f2}");
                }
            }
            else if (city == "Varna")
            {
                if (sales < 0 )
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.045;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sales *= 0.075;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.10;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 10000)
                {
                    sales *= 0.13;
                    Console.WriteLine($"{sales:f2}");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales < 0)
                {
                    Console.WriteLine("error");
                }
                else if (sales >= 0 && sales <= 500)
                {
                    sales *= 0.055;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sales *= 0.08;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sales *= 0.12;
                    Console.WriteLine($"{sales:f2}");
                }
                else if (sales > 10000)
                {
                    sales *= 0.145;
                    Console.WriteLine($"{sales:f2}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
