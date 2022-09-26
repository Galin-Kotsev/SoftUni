using System;

namespace _1_2._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yone = double.Parse(Console.ReadLine());
            double comisionPercent = double.Parse(Console.ReadLine());

            double bitcoinPrice = 1168;
            double yonePrice = 0.15;
            double usdPrice = 1.76;
            double euroPrice = 1.95;

            double bitcoinTotal = bitcoin * bitcoinPrice;
            double yoneTotal = (usdPrice * yonePrice);
            yoneTotal = yoneTotal * yone;
            
            double leva = bitcoinTotal + yoneTotal;
            
            double euro = leva / euroPrice;
            
            double comision = euro * comisionPercent/100;
            
            euro -= comision;
            

            Console.WriteLine($"{euro:f2}");


        }
    }
}
