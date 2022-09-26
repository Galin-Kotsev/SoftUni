using System;

namespace _1_1._Рожден_ден
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;
            double drinks = cake * 0.55;
            double animator = rent / 3;
            double totalAmount = rent + cake + drinks + animator;

            Console.WriteLine(totalAmount);
        }
    }
}
