using System;
using System.Linq;

namespace Matrix_Insert_and_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------------------------
            // MATRIX CREATING & INSERT ELEMENTS

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

            PrintMatrix(rows, cols, matrix);
        }
//-------------------------------------------------------------------------------------------------------------------
        // MATRIX PRINTING METHOD (TESTING)
        private static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
