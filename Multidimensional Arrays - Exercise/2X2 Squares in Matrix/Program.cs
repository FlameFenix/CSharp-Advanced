using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            FillMatrix(matrix);

            int counter = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if(rows + 1 < matrix.GetLength(0)
                    && cols + 1 < matrix.GetLength(1))
                    {
                        char firstChar = matrix[rows, cols];
                        char secondChar = matrix[rows, cols + 1];
                        char thirdChar = matrix[rows + 1, cols];
                        char fourthChar = matrix[rows + 1, cols + 1];

                        if (firstChar == secondChar
                           && firstChar == thirdChar
                           && firstChar == fourthChar)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }

        public static char[,] FillMatrix(char[,] matrix)
        {

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(char.Parse)
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
