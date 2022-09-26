using System;

namespace _4._Цена_за_транспорт
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string travelTime = Console.ReadLine();
            double taxi = 0;
            if (n >= 100)
            {
                double train = n * 0.06;
                Console.WriteLine($"{train:f2}");

            }
            else if (n < 20)
            {
                if (travelTime == "day")
                {

                    taxi = 0.70 + (n * 0.79);
                    Console.WriteLine($"{taxi:f2}");
                }
                else
                {
                    taxi = 0.70 + (n * 0.90);
                    Console.WriteLine($"{taxi:f2}");
                }
            }
            else
            {
                double bus = n * 0.09;
                Console.WriteLine($"{bus:f2}");
            }
        }
    }
}
