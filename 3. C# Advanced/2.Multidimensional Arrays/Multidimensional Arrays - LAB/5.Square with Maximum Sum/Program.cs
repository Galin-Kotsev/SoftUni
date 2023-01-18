using System;
using System.Linq;

namespace _5.Square_with_Maximum_Sum
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
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int sum = 0;
            int rowMax = 0;
            int colMax = 0;

            for (int row = 0; row < rows; row++)
            { 
                for (int col = 0; col < cols; col++)
                {
                    int currSum = 0;

                    if (row >= rows -1 || col >= cols -1)
                    {
                        continue;
                    }
                    currSum+= matrix[row, col];
                    currSum+= matrix[row+1, col];
                    currSum+= matrix[row, col + 1];
                    currSum+= matrix[row+1,col+1];

                    if (currSum > sum)
                    {
                        sum = currSum;
                        rowMax = row;
                        colMax = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowMax, colMax]} {matrix[rowMax, colMax + 1]}");
            Console.WriteLine($"{matrix[rowMax+1, colMax]} {matrix[rowMax + 1, colMax + 1]}");
            Console.WriteLine(sum);
        }
    }
}
