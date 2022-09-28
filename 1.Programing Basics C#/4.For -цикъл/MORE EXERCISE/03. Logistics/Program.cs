using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bus = 0;
            double truck = 0;
            double train = 0;
            
            for (int i = 0; i < n; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    bus += weight;
                }
                else if (weight >= 4 && weight <= 11)
                {
                    truck += weight;
                }
                else
                {
                    train += weight;
                }

            }
            double totalWeight = bus + truck + train;
            double tonePrice = (bus*200+truck*175+train*120)/ totalWeight;
            double busPrice = bus / totalWeight * 100;
            double truckPrice = truck / totalWeight * 100;
            double trainPrice = train / totalWeight * 100;

            Console.WriteLine($"{tonePrice:f2}");
            Console.WriteLine($"{busPrice:f2}%");
            Console.WriteLine($"{truckPrice:f2}%");
            Console.WriteLine($"{trainPrice:f2}%");
            
        }
    }
}
