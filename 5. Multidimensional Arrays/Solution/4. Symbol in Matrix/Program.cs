using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char findSymbol = char.Parse(Console.ReadLine());
            bool isFind = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == findSymbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFind = true;
                        break;
                    }
                }
            }
            if (!isFind)
            {
                Console.WriteLine($"{findSymbol} does not occur in the matrix");
            }
        }
    }
}
