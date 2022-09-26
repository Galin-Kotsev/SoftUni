using System;

namespace _6._Рибна_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double clamPrice = 7.50;

            double skPrice = double.Parse(Console.ReadLine()); 
            double cacaPrice = double.Parse(Console.ReadLine()); 
            double plKg = double.Parse(Console.ReadLine()); 
            double sfKg = double.Parse(Console.ReadLine()); 
            double clamKg = double.Parse(Console.ReadLine());

            double plPrice = skPrice + skPrice * 0.60;
           

            double plsum = plKg * plPrice;
           

            double sfPrice = cacaPrice + cacaPrice * 0.80;
            
            double sfsum = sfKg * sfPrice;
            

            double clamSum = clamKg * clamPrice;
           

            double ordersum = plsum + sfsum + clamSum;
            Console.WriteLine($"{ordersum:f2}");

        }
    }
}
