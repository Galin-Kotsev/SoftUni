using System;

namespace _4._Магазин_за_детски_играчки
{
    class Program
    {
        static void Main(string[] args)
        {
            // Цена на Играчките
            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            // Input peaces per item
            double vacantionPrice = double.Parse(Console.ReadLine());
            double puzzlePc = double.Parse(Console.ReadLine());
            double dollsPc = double.Parse(Console.ReadLine());
            double bearPc = double.Parse(Console.ReadLine());
            double minionPc = double.Parse(Console.ReadLine());
            double truckPc = double.Parse(Console.ReadLine());
            //Сума за Поръчката:
            double sum = puzzlePc * puzzlePrice + dollsPc * dollPrice + bearPc * bearPrice + minionPc * minionPrice + truckPc * truckPrice;
            // Общ брой играчки :
            double toysTotal = puzzlePc + dollsPc + bearPc + minionPc + truckPc;
            double discount = 0;
            if (toysTotal > 50)
            {
            discount = sum * 0.25;
            }
            double endPrice = sum - discount ;
            double rent = endPrice * 0.10;
            double winnings = endPrice - rent;
            double clearCash = winnings - vacantionPrice;
            double clearCash2 = vacantionPrice - winnings;
            if (winnings >= vacantionPrice) 
            {
                Console.WriteLine($"Yes! {clearCash:f2} lv left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money! {clearCash2:f2} lv needed.");
            }




        }
    }
}
            
