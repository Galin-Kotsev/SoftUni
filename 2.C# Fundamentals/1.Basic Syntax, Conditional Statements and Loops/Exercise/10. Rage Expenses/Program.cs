using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyPrice = double.Parse(Console.ReadLine());
            double disPrice = double.Parse(Console.ReadLine());

            int headCount = 0;
            int mouseCount = 0;
            int keyCount = 0;
            int disCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if ( i%2==0)
                {
                    headCount++;
                }

                if (i%3==0)
                {
                    mouseCount++;
                }
                if (i%6==0)
                {
                    keyCount++;
                }
                if(i%12==0)
                {
                    disCount++;
                }
            }
            double setupCalc = headCount * headPrice + mouseCount * mousePrice + keyCount * keyPrice + disCount * disPrice;

            Console.WriteLine($"Rage expenses: {setupCalc:f2} lv.");
        }
    }
}
