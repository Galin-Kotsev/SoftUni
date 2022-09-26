using System;

namespace _04._Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSales = 0;
            double totalRating = 0;
        
            for (int i = 0; i < n; i++)
            {
                int salesRating = int.Parse(Console.ReadLine());
                int rating = salesRating % 10;
                double sales = salesRating / 10;

                if (rating == 2)
                {
                    sales = 0;
                }
                else if (rating == 3)
                {
                    sales /= 2;
                }
                else if (rating == 4)
                {
                    sales *= 0.70;
                }
                else if (rating == 5)
                {
                    sales *= 0.85;
                }

                totalSales += sales;
                totalRating += rating;
            }

            Console.WriteLine($"{totalSales:f2}");
            Console.WriteLine($"{totalRating / n:f2}");
        }
    }
}
