using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];


            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;

                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}


