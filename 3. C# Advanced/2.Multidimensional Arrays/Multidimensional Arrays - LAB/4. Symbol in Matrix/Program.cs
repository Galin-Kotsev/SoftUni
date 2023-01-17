using System;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(char[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            char searchedChar = char.Parse(Console.ReadLine());

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == searchedChar)
                    {
                        Console.WriteLine((matrix[row,col]));
                    }
                    
                }
            }
        }
    }
}
