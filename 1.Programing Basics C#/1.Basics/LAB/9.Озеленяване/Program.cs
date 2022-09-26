using System;

namespace _9.Озеленяване
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceM2 = 7.61;
            double discountSize = 0.18;
            double sizeM2 = double.Parse(Console.ReadLine());

            double order = sizeM2 * priceM2;
            

            double discount = discountSize * order;
          

            double finalPrice = order - discount;
            


            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");


        }
    }
}
