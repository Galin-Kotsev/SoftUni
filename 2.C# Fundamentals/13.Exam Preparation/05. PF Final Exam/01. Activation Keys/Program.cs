using System;
using System.IO;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] inputs = input.Split(">>>");

                string command = inputs[0];

                if (command == "Slice")
                {
                    int startIndex = int.Parse(inputs[1]);
                    int endIndex = int.Parse(inputs[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(activationKey);
                }

                if (command == "Flip")
                {
                    string command2 = inputs[1];
                    int startIndex = int.Parse(inputs[2]);
                    int endIndex = int.Parse(inputs[3]);

                    string upperKey;
                    string firstCh;
                    string lastCh;

                    if (command2 == "Upper")
                    {
                        upperKey = activationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                        firstCh = activationKey.Substring(0, startIndex);
                        lastCh = activationKey.Substring(endIndex, activationKey.Length - endIndex);

                        activationKey = $"{firstCh}{upperKey}{lastCh}";

                        Console.WriteLine(activationKey);
                    }
                    else if (command2 == "Lower")
                    {
                        upperKey = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                        firstCh = activationKey.Substring(0, startIndex);
                        lastCh = activationKey.Substring(endIndex, activationKey.Length - endIndex);

                        activationKey = $"{firstCh}{upperKey}{lastCh}";

                        Console.WriteLine(activationKey);
                    }
                }

                if (command == "Contains")
                {
                    string ch = inputs[1];

                    if (!activationKey.Contains(ch))
                    {
                        Console.WriteLine("Substring not found!");
                    }
                    else
                    {
                        Console.WriteLine($"{activationKey} contains {ch}");

                    }
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
