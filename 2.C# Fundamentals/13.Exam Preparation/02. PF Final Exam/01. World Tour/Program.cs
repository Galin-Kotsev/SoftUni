using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Travel")
            {

                string[] inputs = input.Split(":");

                string command = inputs[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(inputs[1]);
                    string location = inputs[2];

                    if (index >= 0 && index <= stops.Length - 1)
                    {
                        stops = stops.Insert(index, location);
                    }
                }

                if (command == "Remove Stop")
                {
                    int index = int.Parse(inputs[1]);
                    int index2 = int.Parse(inputs[2]);

                    if (index >= 0 && index <= stops.Length - 1 && index2 >= 0 && index2 <= stops.Length - 1)
                    {
                        stops = stops.Remove(index, index2 - index + 1);
                    }    
                }

                if (command == "Switch")
                {
                    string oldStop = inputs[1];
                    string newStop = inputs[2];

                    stops = stops.Replace(oldStop, newStop);
                }

                Console.WriteLine(stops);
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
