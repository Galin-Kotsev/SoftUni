using System;

namespace _7._Доставка_на_храна
{
    class Program
    {
        static void Main(string[] args)
        {
            double chikenMenu = 10.35;
            double fishMenu = 12.40;
            double vegyMenu = 8.15;

            double chiken = double.Parse(Console.ReadLine());
            double fish = double.Parse(Console.ReadLine());
            double vegy = double.Parse(Console.ReadLine());

            double orderPrice = (chiken * chikenMenu) + (fish * fishMenu) + (vegy * vegyMenu);

            double desertPrice = orderPrice * 0.2;

            double totalShteta = orderPrice + desertPrice +2.5;
            Console.WriteLine(totalShteta);


        }
    }
}
