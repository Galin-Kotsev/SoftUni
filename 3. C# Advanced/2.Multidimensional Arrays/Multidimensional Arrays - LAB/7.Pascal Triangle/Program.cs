using System;
using System.Linq;

namespace _7.Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[n][];

            pascalTriangle[0] = new long[] { 1 };

            for (int row = 1; row < n; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                pascalTriangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                pascalTriangle[row][row] = 1;
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(String.Join(" ", pascalTriangle[row]));
            }
        }
    }
}
