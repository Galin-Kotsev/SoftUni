using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int order = int.Parse(Console.ReadLine());
            double priceSum = 0;

            for (int i = 1; i <= order; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsCount = int.Parse(Console.ReadLine());

                double orderPrice = ((days * capsCount) * capsulePrice);

                priceSum += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${priceSum:f2}");

        }
    }
}


