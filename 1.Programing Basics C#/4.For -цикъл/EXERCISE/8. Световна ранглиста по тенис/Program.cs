using System;

namespace _8._Световна_ранглиста_по_тенис
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int gamePoints = 0;
            double counter = 0;

            for (int i = 0; i < n; i++)
            {
                string turnamentStage = Console.ReadLine();

                if (turnamentStage == "W")
                {
                    startingPoints = startingPoints + 2000;
                    counter++;
                    gamePoints += 2000;
                }
                else if (turnamentStage =="F")
                {
                    startingPoints = startingPoints + 1200;
                    gamePoints += 1200;
                }
                else if (turnamentStage == "SF")
                {
                    startingPoints = startingPoints + 720;
                    gamePoints += 720;
                }

            }
            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {((gamePoints) / n)}");
            Console.WriteLine($"{(counter / n)*100:F2}%");

        }
    }
}
