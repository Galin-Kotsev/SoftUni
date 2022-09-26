using System;

namespace _6._Пребоядисване
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cover
            double coverPrice = 1.50;
            // paint
            double paintPrice = 14.50;
            //Paint disolver
            double disolverPrice = 5;
            

            double cover = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double disolver = double.Parse(Console.ReadLine());
            // Material Total Price
            double matPrice = ((cover + 2) * coverPrice) + ((paint * 1.1)*paintPrice) + (disolver * disolverPrice) + 0.40;
            //Worker Price
            double workHours = double.Parse(Console.ReadLine());      
            double worker = (matPrice * 0.3)* workHours;
            double sum = worker + matPrice;
            Console.WriteLine(sum);  
        }
    }
}
