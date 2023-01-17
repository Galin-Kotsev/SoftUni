using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
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
            int sum = 0;

            int[,] matrix = new int[rows, cols];    

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sum += elements.Sum();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            Console.WriteLine(dementions[0]);
            Console.WriteLine(dementions[1]);            
            Console.WriteLine(sum);            
        }
    }
}
