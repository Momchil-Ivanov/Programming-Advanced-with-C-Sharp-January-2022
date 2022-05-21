using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = inputNumbers[col];
                }   
            }

            int rightLeftSum = 0;
            int leftRightSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rightLeftSum += matrix[i, matrix.GetLength(1) - 1 - i];
                leftRightSum += matrix[i, i];
            }
            
            Console.WriteLine(Math.Abs(leftRightSum-rightLeftSum));
        }
    }
}
