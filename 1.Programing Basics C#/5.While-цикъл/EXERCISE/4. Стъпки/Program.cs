using System;

namespace _4._Стъпки
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = (Console.ReadLine());
            int stepsSum = 0;
            if (steps == "Going home")
            {
                stepsSum += int.Parse(Console.ReadLine());

                if (stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(10000 - stepsSum)} more steps to reach goal.");
                }
            }


            while (steps != "Going home")
            {
                int currentSteps = int.Parse(steps);
                stepsSum += currentSteps;
                if (stepsSum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsSum-10000} steps over the goal!");
                    break;
                }
                steps = Console.ReadLine();

                if (steps == "Going home")
                {
                    stepsSum += int.Parse(Console.ReadLine());

                    if (stepsSum>=10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Abs(10000 - stepsSum)} more steps to reach goal.");
                    }
                    break;
                }
            }
         }
    }
}

