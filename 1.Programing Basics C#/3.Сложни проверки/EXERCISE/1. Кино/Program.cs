using System;

namespace _1._Кино
{
    class Program
    {
        static void Main(string[] args)
        {
            string tickedType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0.0;

            if (tickedType == "Premiere")
            {
                income = row * colums * 12.00;
                Console.WriteLine("{0:f2} leva", income);
            }
            else if (tickedType == "Discount")
            {
                income = row * colums * 5.00;
                Console.WriteLine("{0:f2} leva", income);
            }
            else
            {
                income = row * colums * 7.50;
                Console.WriteLine("{0:f2} leva", income);
            }

        }
    }
}
