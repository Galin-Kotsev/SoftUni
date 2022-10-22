using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colection = Console.ReadLine()
                .Split(", ")
                .ToList();

            string inputs = Console.ReadLine();

            while (inputs != "Craft!")
            {
                string[] input = inputs.Split(" - ");
                string command = input[0];
                string item = input[1];
                 


                if (command == "Collect")
                {
                    if (!colection.Contains(item))
                    {
                        colection.Add(item);
                    }
                    else
                    {
                        inputs = Console.ReadLine();
                        continue;
                        
                    }
                }
                else if (command == "Drop")
                {
                    if (colection.Contains(item))
                    {
                        colection.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] items = item.Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];

                    if (colection.Contains(oldItem))
                    {
                        colection.Insert(colection.IndexOf(oldItem) + 1, newItem);
                    }
                }
                else if (command == "Renew")
                {
                    if (colection.Contains(item))
                    {
                        colection.Add(item);
                        colection.Remove(item);
                    }
                    
                }

                inputs = Console.ReadLine();
            }
            
            Console.WriteLine(String.Join(", ", colection));
        }
    }
}

