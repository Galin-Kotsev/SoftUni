using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            int shots = 0;

            while (input != "End")
            {

                int index = int.Parse(input);

                if (index < 0 || index >= targets.Count)
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    shots++;

                    int temp = targets[index];

                    targets[index] = -1;

                    for (int i = 0; i < targets.Count; i++)
                    {
                        if (targets[i] >= 0)
                        {
                            if (temp < targets[i])
                            {
                                targets[i] -= temp;
                            }
                            else if (temp >= targets[i])
                            {
                                targets[i] += temp;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shots} -> {String.Join(" ", targets)}");
        }
    }
}
