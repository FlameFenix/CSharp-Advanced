using System;
using System.Linq;

namespace Snake_Moves
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

            string snake = Console.ReadLine();

            int snakeCounter = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                if(rows % 2 == 0)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        matrix[rows, cols] = snake[snakeCounter];
                        snakeCounter++;

                        if (snakeCounter == snake.Length)
                        {
                            snakeCounter = 0;
                        }
                    }
                }
                else
                {
                    for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
                    {
                        matrix[rows, cols] = snake[snakeCounter];
                        snakeCounter++;

                        if (snakeCounter == snake.Length)
                        {
                            snakeCounter = 0;
                        }
                    }
                }
                
            }

            PrintMatrix(matrix);
        }

        public static string[,] FillMatrix(string[,] matrix)
        {

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] numbers = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            return matrix;
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
