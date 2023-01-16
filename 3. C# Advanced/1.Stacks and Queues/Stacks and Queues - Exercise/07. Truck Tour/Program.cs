using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<GasStation> gasStation = new Queue<GasStation>();


            for (int i = 0; i < n; i++)
            {
                int[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                gasStation.Enqueue(new GasStation(info[0], info[1]));
            }

            for (int i = 0; i < gasStation.Count; i++)
            {
                bool enoughFuel = true;
                int tank = 0;

                for (int j = 0; j < gasStation.Count; j++)
                {
                    tank += gasStation.Peek().Fuel - gasStation.Peek().Distance;
                    if (tank < 0)
                    {
                        enoughFuel = false;
                    }
                    gasStation.Enqueue(gasStation.Dequeue());
                }

                gasStation.Enqueue(gasStation.Dequeue());

                if (enoughFuel)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
class GasStation
{
    public GasStation(int fuel, int distance)
    {
        Fuel = fuel;
        Distance = distance;
    }

    public int Fuel { get; set; }
    public int Distance { get; set; }
}
