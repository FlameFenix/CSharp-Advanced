using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixLength = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            int[,] matrix = ReadMatrix(matrixLength[0], matrixLength[1]);

            int biggestSum = 0;
            int[,] bestMatrix = new int[2, 2];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int currentSum = 0;

                    if(rows >= 0 && rows + 1 < matrix.GetLength(0)
                        && cols >= 0 && cols + 1 < matrix.GetLength(1))
                    {
                        int firstNumber = matrix[rows, cols];
                        int secondNumber = matrix[rows, cols + 1];
                        int thirdNumber = matrix[rows + 1, cols];
                        int fourthNumber = matrix[rows + 1, cols + 1];

                        currentSum = firstNumber + secondNumber + thirdNumber + fourthNumber;
                        if (currentSum > biggestSum)
                        {
                            biggestSum = currentSum;
                            bestMatrix[0, 0] = firstNumber;
                            bestMatrix[0, 1] = secondNumber;
                            bestMatrix[1, 0] = thirdNumber;
                            bestMatrix[1, 1] = fourthNumber;
                        }
                    } 
                }
            }

            for (int rows = 0; rows < bestMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < bestMatrix.GetLength(1); cols++)
                {
                    Console.Write($"{bestMatrix[rows, cols]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(biggestSum);
        }

        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows ; row++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
    }
}
