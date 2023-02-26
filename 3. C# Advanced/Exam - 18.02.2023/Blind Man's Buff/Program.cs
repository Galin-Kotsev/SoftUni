using System;
using System.Linq;

namespace Blind_Man_s_Buff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dementions = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

            int rows = dementions[0];
            int cols = dementions[1];

            int playerX = 0;
            int playerY = 0;

            int tochedOpponents = 0;
            int moves = 0;
            int totalOppopnents = 0;

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                    if (elements[col] == 'P')
                    {
                        totalOppopnents++;
                    }
                    if (elements[col] == 'B')
                    {
                        playerX = row;
                        playerY = col;
                    }

                }
            }

            Console.WriteLine(matrix.GetLength(0));
            string command = Console.ReadLine();
            while (tochedOpponents != totalOppopnents && command != "Finish")
            {
                int newPosX = playerX;
                int newPosY = playerY;

                switch (command)
                {
                    case "up":
                        newPosX = playerX - 1;
                        break;
                    case "down":
                        newPosX = playerX + 1;
                        break;
                    case "left":
                        newPosY = playerY - 1;
                        break;
                    case "right":
                        newPosY = playerY + 1;
                        break;
                    default:
                        break;
                }

                if (newPosX >= 0 && newPosX < cols && newPosY >= 0 && newPosY < rows)
                {
                    if (matrix[newPosX, newPosY] == '-')
                    {
                        matrix[playerX, playerY] = '-';
                        moves++;
                        playerX = newPosX;
                        playerY = newPosY;
                        matrix[playerX, playerY] = 'B';
                    }
                    else if (matrix[newPosX, newPosY] == 'P')
                    {
                        matrix[playerX, playerY] = '-';
                        moves++;
                        tochedOpponents++;
                        playerX = newPosX;
                        playerY = newPosY;
                        matrix[playerX, playerY] = 'B';
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {tochedOpponents} Moves made: {moves}");

            //PrintMatrix(rows, cols, matrix);
        }


        static void PrintMatrix(int rows, int cols, char[,] matrix)
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
