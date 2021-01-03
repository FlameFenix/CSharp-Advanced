using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();
            int n = matrixSize[0];
            int m = matrixSize[1];

            int[,] matrix = new int[n, m];

            FillMatrix(matrix);

            int bestSum = 0;

            int[,] bestMatrix = new int[3, 3];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int sum = 0;

                    if (rows + 2 < matrix.GetLength(0)
                    && cols + 2 < matrix.GetLength(1))
                    {
                        int firsNum = matrix[rows, cols];
                        int secondNum = matrix[rows, cols + 1];
                        int thirdNum = matrix[rows, cols + 2];
                        int fourthNum = matrix[rows + 1, cols];
                        int fivethNum = matrix[rows + 1, cols + 1];
                        int sixthNum = matrix[rows + 1, cols + 2];
                        int seventhNum = matrix[rows + 2, cols];
                        int eighthNum = matrix[rows + 2, cols + 1];
                        int ninthNum = matrix[rows + 2, cols + 2];

                        sum = firsNum + secondNum + thirdNum + fourthNum + fivethNum + sixthNum + seventhNum + eighthNum + ninthNum;

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestMatrix[0, 0] = firsNum;
                            bestMatrix[0, 1] = secondNum;
                            bestMatrix[0, 2] = thirdNum;
                            bestMatrix[1, 0] = fourthNum;
                            bestMatrix[1, 1] = fivethNum;
                            bestMatrix[1, 2] = sixthNum;
                            bestMatrix[2, 0] = seventhNum;
                            bestMatrix[2, 1] = eighthNum;
                            bestMatrix[2, 2] = ninthNum;
                        }

                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            PrintMatrix(bestMatrix);
        }
        public static int[,] FillMatrix(int[,] matrix)
        {

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
} 


