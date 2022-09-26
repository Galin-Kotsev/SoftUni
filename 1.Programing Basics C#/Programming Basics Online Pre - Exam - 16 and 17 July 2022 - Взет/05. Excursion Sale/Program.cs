using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaPakage = int.Parse(Console.ReadLine());
            int mountainPakage = int.Parse(Console.ReadLine());
            int seaCount = 0;
            int mountainCount = 0;
            int totalPrice = 0;


            string pakage = Console.ReadLine();
            while (pakage != "Stop")
            {
                if (pakage == "sea")
                {
                    if (seaCount == seaPakage)
                    {
                        pakage = Console.ReadLine();
                        continue;

                    }
                    seaCount++;
                    totalPrice += 680;
                }
                else if (pakage == "mountain")
                {
                    if (mountainCount == mountainPakage)
                    {
                        pakage = Console.ReadLine();
                        continue;

                    }
                    mountainCount++;
                    totalPrice += 499;
                }
                if (seaCount == seaPakage && mountainCount == mountainPakage)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }


               pakage = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {totalPrice} leva.");

        }
    }
}
