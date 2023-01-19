using System;

namespace _4.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
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

            bool contains = false;

            int rowPosition = 0;
            int colPosition = 0;

            for (int row = 0; row < rows; row++)
            {
                if (contains)
                {
                    break;
                }

                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == searchedChar)
                    {
                        contains = true;
                        rowPosition = row;
                        colPosition = col;
                        break;
                    }
                }
            }

            if (contains)
            {
                Console.WriteLine(($"({rowPosition}, {colPosition})"));
            }
            else
            {
                Console.WriteLine($"{searchedChar} does not occur in the matrix");
            }
        }
    }
}
