using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToArray();

            string[,] matrix = new string[rowCol[0], rowCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] newRowInput = Console.ReadLine().Split(' ')
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRowInput[col];
                }
            }

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "END")
            {
                if (command.Length != 5)
                {
                    Console.WriteLine($"Invalid input!");
                }

                else if (command[0] == "swap")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (row1 < rowCol[0] && row2 < rowCol[0]
                        && col1 < rowCol[1] && col2 < rowCol[1] && command.Length == 5)
                    {
                        string temporaryCell = matrix[row1, col1];

                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temporaryCell;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input!");
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}