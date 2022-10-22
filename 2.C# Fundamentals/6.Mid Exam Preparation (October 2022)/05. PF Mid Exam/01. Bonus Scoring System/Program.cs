using System;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());

            double maxAtendances = 0;
            double maxBonus = 0;

            for (int i = 0; i < students; i++)
            {
                double atendances = double.Parse((Console.ReadLine()));

                double totalBonus = atendances / lectures * (5 + addBonus);

                if (atendances >= maxAtendances)
                {
                    maxAtendances = atendances;
                    maxBonus = totalBonus;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAtendances} lectures.");
        }
    }
}