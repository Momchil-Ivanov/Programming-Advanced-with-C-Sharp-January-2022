using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            int primaryDiagonal = 0;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += (matrix[i][i]);
            }

            Console.WriteLine(primaryDiagonal);
        }
    }
}
