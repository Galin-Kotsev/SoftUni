using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace Apocalypse_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> textline 
                = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            Stack<int> medicaments 
                = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            Dictionary<string,int> items = new Dictionary<string,int>();

            items.Add("Patch", 0);
            items.Add("Bandage", 0);
            items.Add("MedKit", 0);

            while (textline.Count > 0 && medicaments.Count > 0) 
            {
                int itemSum = textline.Peek() + medicaments.Peek();

                if (itemSum == 30)
                {
                    items["Patch"]++;
                    textline.Dequeue();
                    medicaments.Pop();
                }
                else if (itemSum == 40)
                {
                    items["Bandage"]++;
                    textline.Dequeue();
                    medicaments.Pop();
                }
                else if (itemSum == 100)
                {
                    items["MedKit"]++;
                    textline.Dequeue();
                    medicaments.Pop();
                }
                else if (itemSum > 100)
                {
                    items["MedKit"]++;
                    textline.Dequeue();
                    medicaments.Pop();
                    itemSum -= 100;
                    int newItem = medicaments.Pop() + itemSum;
                    medicaments.Push(newItem);
                }
                else
                {
                    textline.Dequeue();
                    medicaments.Push(medicaments.Pop()+10);
                }
            }

            if (medicaments.Count <= 0 && textline.Any())
            {
                Console.WriteLine("Medicaments are empty.");

                foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x=>x.Key)) 
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }

                Console.WriteLine($"Textiles left: {string.Join(", ", textline)}");
            }
            else if (textline.Count <= 0 && medicaments.Any())
            {
                Console.WriteLine("Textiles are empty.");

                foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
            }
            else if (medicaments.Count <= 0 && textline.Count <= 0)
            {
                Console.WriteLine("Textiles and medicaments are both empty.");

                foreach (var item in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (item.Value > 0)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
