using System;
using System.Collections.Generic;

namespace _03._Wild_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animalList = new Dictionary<string, int>();
            var areaList = new Dictionary<string,int>();
            var animalAreaList = new Dictionary<string,string>();

            string input;

            while ((input = Console.ReadLine()) != "EndDay")
            {
                string[] inputs = input.Split(": ",StringSplitOptions.RemoveEmptyEntries);

                string command = inputs[0];
                string[] inputs2 = inputs[1].Split("-");
                string animalName = inputs2[0];

                if (command == "Add")
                {
                    int foodQuantity = int.Parse(inputs2[1].ToString());
                    string area = inputs2[2];

                    if (!animalList.ContainsKey(animalName))
                    {
                        animalList.Add(animalName, foodQuantity);
                        animalAreaList.Add(animalName, area);

                        if (!areaList.ContainsKey(area))
                        {
                            areaList.Add(area, 1);
                        }
                        else
                        {
                            areaList[area]++;
                        }
                    }
                    else
                    {
                        animalList[animalName] += foodQuantity;
                    }
                }

                if (command == "Feed")
                {
                    int foodQuantity = int.Parse(inputs2[1]);

                    if (animalList.ContainsKey(animalName))
                    {
                        animalList[animalName] -= foodQuantity;

                        if (animalList[animalName] <= 0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            animalList.Remove(animalName);
                            areaList[animalAreaList[animalName]] -= 1;
                        }
                    }
                }
            }

            Console.WriteLine("Animals:");
            foreach (var (Key,Value) in animalList)
            {
                Console.WriteLine($" {Key} -> {Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var animal in areaList)
            {
                if (animal.Value > 0)
                {
                    Console.WriteLine($" {animal.Key}: {animal.Value}");
                }
            }

        }
    }
}
