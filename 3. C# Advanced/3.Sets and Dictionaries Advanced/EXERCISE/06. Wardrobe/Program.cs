using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe
                = new Dictionary<string,Dictionary<string,int>>();

            for (int i = 0; i < n; i++)
            {
                string[] clothing = Console.ReadLine()
                    .Split(new string[] {" -> ",","},StringSplitOptions.RemoveEmptyEntries);

                string color = clothing[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1;j < clothing.Length; j++) 
                {
                    string currCloth = clothing[j];


                    if (!wardrobe[color].ContainsKey(currCloth))
                    {
                        wardrobe[color].Add(currCloth, 1);
                    }
                    else
                    {
                        wardrobe[color][currCloth]++;
                    }
                }
            }

            string[] find = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string findColor = find[0];
            string findCloth = find[1];

            foreach (var clothByColor in wardrobe)
            {
                Console.WriteLine($"{clothByColor.Key} clothes:");

                foreach (var cloth in clothByColor.Value)
                {
                    string item = $"* {cloth.Key} - {cloth.Value}";

                    if (clothByColor.Key == findColor && cloth.Key == findCloth)
                    {
                        item += " (Found!)";
                    }
                    Console.WriteLine(item);
                }
            }

        }
    }
}
