using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var carsList = new Dictionary<string, List<int>>();

            string input = string.Empty;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] inputs = input.Split("|");

                string car = inputs[0];
                int miles = int.Parse(inputs[1]);
                int fuel = int.Parse(inputs[2]);
                
                carsList.Add(car, new List<int>() { miles, fuel });
            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] inputs = input.Split(" : ");

                string command = inputs[0];

                if (command == "Drive")
                {
                    string car = inputs[1];
                    int miles = int.Parse(inputs[2]);
                    int fuel = int.Parse(inputs[3]);

                    if (carsList.ContainsKey(car))
                    {
                        if (carsList[car][1] < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else if (carsList[car][1] >= fuel)
                        {
                            carsList[car][0] += miles;
                            carsList[car][1] -= fuel;

                            Console.WriteLine($"{car} driven for {miles} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (carsList[car][0] >= 100_000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");

                            carsList.Remove(car);
                        }
                    }
                }

                if (command == "Refuel")
                {
                    string car = inputs[1];
                    int fuel = int.Parse(inputs[2]);

                    if (carsList.ContainsKey(car))
                    {
                        if (carsList[car][1] + fuel < 75)
                        {
                            carsList[car][1] += fuel;

                            Console.WriteLine($"{car} refueled with {fuel} liters");
                        }
                        else
                        {
                            //??
                            Console.WriteLine($"{car} refueled with {75 - carsList[car][1]} liters");
                            carsList[car][1] = 75;
                        }
                    }
                }

                if (command == "Revert")
                {
                    string car = inputs[1];
                    int miles = int.Parse(inputs[2]);

                    carsList[car][0] -= miles;

                    Console.WriteLine($"{car} mileage decreased by {miles} kilometers");

                    if (carsList[car][0] < 10_000)
                    {
                        carsList[car][0] = 10_000;
                    }
                }
            }

            foreach (var (Key, Value) in carsList)
            {
                Console.WriteLine($"{Key} -> Mileage: {Value[0]} kms, Fuel in the tank: {Value[1]} lt.");
            }
        }
    }
}

