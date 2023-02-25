using System;
using System.Data.Common;
using System.Numerics;

namespace Practical_7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter row size: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column size: ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            SumOfMatrices(TwoMatricsSum(Matrices(row, column), Matrices(row, column)));
        }

        static int[,] Matrices(int row, int column)
        {
            int[,] matrix = new int[row, column];
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write($"Enter number for index {r},{c}: ");
                    matrix[r, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=================================");
            return matrix;
        }
        static int[,] TwoMatricsSum(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix3;
        }
        static void SumOfMatrices(int[,] matrix)
        {
            Console.WriteLine("here is sum of matrices");
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(matrix[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}