using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet 
                = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> drumSet2 = new List<int>();

            drumSet2.AddRange(drumSet);

            string input = string.Empty;

            while((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                string[] inputs = input.Split();

                int power = int.Parse(inputs[0]);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;
                    
                    if (drumSet[i] <= 0)
                    {
                        if (savings >= drumSet2[i] * 3 && savings > 0)
                        {
                            drumSet[i] = drumSet2[i];
                            
                            int newDrum = drumSet2[i] * 3;

                            savings -= newDrum;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumSet2.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            
            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
