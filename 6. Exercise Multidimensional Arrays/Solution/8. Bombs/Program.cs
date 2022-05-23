using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int[] indexes = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < indexes.Length; i+=2)
            {
                int row = indexes[i];
                int col = indexes[i + 1];

                if (matrix[row, col] <= 0)
                {
                    continue;
                }

                int value = matrix[row, col];

                // up, down, left, right, upLeft, upRight, downLeft, downRight

                if (IsInRange(matrix, row - 1, col) && matrix[row - 1, col] > 0)
                {
                    matrix[row - 1, col] -= value;
                }

                if (IsInRange(matrix, row + 1, col) && matrix[row + 1, col] > 0)
                {
                    matrix[row + 1, col] -= value;
                }

                if (IsInRange(matrix, row, col - 1) && matrix[row, col - 1] > 0)
                {
                    matrix[row, col - 1] -= value;
                }

                if (IsInRange(matrix, row, col + 1) && matrix[row, col + 1] > 0)
                {
                    matrix[row, col + 1] -= value;
                }

                if (IsInRange(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= value;
                }

                if (IsInRange(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)
                {
                    matrix[row - 1, col + 1] -= value;
                }

                if (IsInRange(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
                {
                    matrix[row + 1, col + 1] -= value;
                }

                if (IsInRange(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
                {
                    matrix[row + 1, col - 1] -= value;
                }

                matrix[row, col] = 0;
            }

            int aliveCount = 0;
            int aliveSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCount++;
                        aliveSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCount}");
            Console.WriteLine($"Sum: {aliveSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        private static bool IsInRange(int[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) &&
                col >= 0 && col < board.GetLength(1);
        }
    }
}
