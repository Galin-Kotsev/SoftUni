using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parkingSystem = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];

                if (command == "register")
                {
                    string user = input[1];
                    string plateNumber = input[2];

                    if (!parkingSystem.ContainsKey(user))
                    {
                        parkingSystem.Add(user, plateNumber);
                        Console.WriteLine($"{user} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string user = input[1];

                    if (!parkingSystem.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{user} unregistered successfully");
                        parkingSystem.Remove(user);
                    }
                }
            }

            foreach (var (Key, Value) in parkingSystem)
            {
                Console.WriteLine($"{Key} => {Value}");
            }
        }
    }
}
