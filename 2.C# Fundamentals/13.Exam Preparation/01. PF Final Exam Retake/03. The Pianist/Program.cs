using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input;

            var ComposerList = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] inputs = input.Split("|");

                string piece = inputs[0];
                string composer = inputs[1];
                string key = inputs[2];

                ComposerList.Add(piece, new List<string>() { composer, key });
            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] inputs = input.Split("|");

                string command = inputs[0];
                

                if (command == "Add")
                {
                    string piece = inputs[1];
                    string composer = inputs[2];
                    string key = inputs[3];

                    if (!ComposerList.ContainsKey(piece))
                    {
                        ComposerList.Add(piece, new List<string>() { composer, key });

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }

                if (command == "Remove")
                {
                    string piece = inputs[1];
                    
                    if (ComposerList.ContainsKey(piece))
                    {
                        Console.WriteLine($"Successfully removed {piece}!");
                        ComposerList.Remove(piece);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                if (command == "ChangeKey")
                {
                    string piece = inputs[1];
                    string newkey = inputs[2];

                    if (ComposerList.ContainsKey(piece))
                    {
                        ComposerList[piece][1] = newkey;

                        Console.WriteLine($"Changed the key of {piece} to {newkey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var (Key, Value) in ComposerList)
            {
                Console.WriteLine($"{Key} -> Composer: {Value[0]}, Key: {Value[1]}");
            }
        }
    }
}
