using System;

namespace _6._Магазин_за_цветя
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double order = double.Parse(Console.ReadLine());

            double price = magnolias * 3.25 + hyacinths * 4 + roses * 3.50 + cactus * 8;
            double tax = price - price * 0.05;
            double winnings = tax;
            double moneyTotal = order - winnings;
            moneyTotal = Math.Abs(moneyTotal);

            if (order>winnings)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyTotal)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(moneyTotal)} leva.");
            }
            
            

        }
    }
}
