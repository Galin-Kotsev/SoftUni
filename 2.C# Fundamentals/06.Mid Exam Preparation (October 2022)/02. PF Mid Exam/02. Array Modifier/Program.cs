using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> shit = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                
                if (command == "swap")
                {
                    int index = int.Parse(inputs[1]);
                    int index2 = int.Parse(inputs[2]);

                    int temp = shit[index];
                    int temp2 = shit[index2];
                    shit[index] = temp2;
                    shit[index2] = temp;
                }
                else if (command == "multiply")
                {
                    int index = int.Parse(inputs[1]);
                    int index2 = int.Parse(inputs[2]);

                    shit[index] *= shit[index2];
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < shit.Count; i++)
                    {
                        shit[i] -= 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", shit));
        }
    }
}
