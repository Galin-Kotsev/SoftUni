using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double sunLounger = double.Parse(Console.ReadLine());
            double sunUmbrela = double.Parse(Console.ReadLine());

            double entraceMoney = people * entranceFee;
            double sunLoungerMoney = Math.Ceiling(people * 0.75);
            sunLoungerMoney *= sunLounger;
            double sunUmbrelaMoney = Math.Ceiling(people * 0.50);
            sunUmbrelaMoney *= sunUmbrela;

            double totalPrice = entraceMoney + sunLoungerMoney + sunUmbrelaMoney;

            Console.WriteLine($"{totalPrice:f2} lv.");
            

        }
    }
}
