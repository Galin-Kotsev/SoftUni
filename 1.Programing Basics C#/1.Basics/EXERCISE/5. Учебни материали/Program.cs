using System;

namespace _5._Учебни_материали
{
    class Program
    {
        static void Main(string[] args)
        {
            //pen price
            double penPrice = 5.80;
            //marker price
            double markerPrice = 7.20;
            //toxic price
            double toxicPrice = 1.20;

            double pen = double.Parse(Console.ReadLine());
            double marker = double.Parse(Console.ReadLine());
            double toxic = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            //Total Price 
            double totalPrice = (pen * penPrice) + (marker * markerPrice) + (toxic * toxicPrice);
            // Total Price discount (tpd) :D
            double tpd = totalPrice - (totalPrice * discount) / 100;
            
            Console.WriteLine(tpd);





        }
    }
}
