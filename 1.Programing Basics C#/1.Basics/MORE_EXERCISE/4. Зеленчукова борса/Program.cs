using System;

namespace _4._Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegiPrice = double.Parse(Console.ReadLine());
            double frotPrice = double.Parse(Console.ReadLine());
            double vegiKG = double.Parse(Console.ReadLine());
            double frotKG = double.Parse(Console.ReadLine());

            double allCost = (vegiPrice * vegiKG) + (frotPrice * frotKG);
            double euroCost = allCost / 1.94;
            Console.WriteLine($"{euroCost:f2}");

        }
    }
}
