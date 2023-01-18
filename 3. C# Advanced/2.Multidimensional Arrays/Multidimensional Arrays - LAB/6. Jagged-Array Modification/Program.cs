using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows  = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] inserts = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = inserts;
            }

            string tokens = string.Empty;

            while ((tokens = Console.ReadLine()) != "END")
            {
                string[] tokens2 = tokens
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens2[0];
                int index = int.Parse(tokens2[1]);
                int index1 = int.Parse(tokens2[2]);
                int value = int.Parse(tokens2[3]);

                if (index >= 0 && index < jaggedArray.Length) // row Check
                {
                    if (index1 >= 0 && index1 < jaggedArray[index].Length) // col Check
                    {
                        if (command == "Add")
                        {
                            jaggedArray[index][index1] += value;
                        }

                        if (command == "Subtract")
                        {
                            jaggedArray[index][index1] -= value;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            //print jaggedAray

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ",jaggedArray[row]));
            }
        }
    }
}
