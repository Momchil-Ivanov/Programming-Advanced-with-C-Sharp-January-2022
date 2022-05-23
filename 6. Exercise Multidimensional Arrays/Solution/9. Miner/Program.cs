using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] directions = Console.ReadLine().Split();

            char[,] matrix = new char[size, size];

            int coalCount = 0;
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col][0];

                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }

                    else if (matrix[row, col] == 's')
                    {
                        playerRow = row;  
                        playerCol = col;
                    }
                }
           
            }

            foreach (var direction in directions)
            {
                int nextRow = 0;
                int nextCol = 0;

                if (direction == "left")
                {
                    nextCol = -1;
                }

                if (direction == "right")
                {
                    nextCol = 1;
                }

                if (direction == "up")
                {
                    nextRow = -1;
                }

                if (direction == "down")
                {
                    nextRow = 1;
                }

                if (!IsInRange(matrix, playerRow + nextRow, playerCol + nextCol))
                {
                    continue;
                }

                playerRow += nextRow;
                playerCol += nextCol;

                if (matrix[playerRow, playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    Environment.Exit(0);
                }

                if (matrix[playerRow, playerCol] == 'c')
                {
                    matrix[playerRow, playerCol] = '*';
                    coalCount--;

                    if (coalCount == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        Environment.Exit(0);
                    }
                }
            }

            Console.WriteLine($"{coalCount} coals left. ({playerRow}, {playerCol})");

        }

        private static bool IsInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}