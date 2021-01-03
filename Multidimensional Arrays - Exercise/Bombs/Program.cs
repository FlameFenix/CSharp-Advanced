using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            FillMatrix(matrix);

            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < bombs.Length; i++)
            {
                int[] currentBomb = bombs[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int bombRows = currentBomb[0];
                int bombCols = currentBomb[1];

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (bombCols == cols && bombRows == rows)
                        {
                            if(matrix[rows, cols] > 0)
                            {
                                IsIndexExist(matrix, rows, cols);
                            }
                            
                        }
                    }
                }
            }

            int countAlive = 0;
            int sumAlive = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] > 0)
                    {
                        countAlive++;
                        sumAlive += matrix[rows, cols];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {countAlive}");
            Console.WriteLine($"Sum: {sumAlive}");
            PrintMatrix(matrix);
        }

        private static void IsIndexExist(int[,] matrix, int rows, int cols)
        {
            int bomb = matrix[rows, cols];
            
            if (isValidIndex(matrix, rows - 1, cols) && matrix[rows - 1, cols] > 0)
            {
                    matrix[rows - 1, cols] -= bomb;
            }
            if (isValidIndex(matrix, rows - 1, cols - 1) && matrix[rows - 1, cols - 1] > 0)
            {
                    matrix[rows - 1, cols - 1] -= bomb;
            }
            if (isValidIndex(matrix, rows - 1, cols + 1) && matrix[rows - 1, cols + 1] > 0)
            {
                    matrix[rows - 1, cols + 1] -= bomb;
            }

            if (isValidIndex(matrix, rows + 1, cols) && matrix[rows + 1, cols] > 0)
            {
                    matrix[rows + 1, cols] -= bomb;
            }
            if (isValidIndex(matrix, rows + 1, cols + 1) && matrix[rows + 1, cols + 1] > 0)
            {
                    matrix[rows + 1, cols + 1] -= bomb;
            }
            if (isValidIndex(matrix, rows + 1, cols - 1) && matrix[rows + 1, cols - 1] > 0)
            {
                    matrix[rows + 1, cols - 1] -= bomb;
            }

            if (isValidIndex(matrix, rows, cols - 1) && matrix[rows, cols - 1] > 0)
            {
                    matrix[rows, cols - 1] -= bomb;
            }
            if (isValidIndex(matrix, rows, cols + 1) && matrix[rows, cols + 1] > 0)
            {
                    matrix[rows, cols + 1] -= bomb;
            }
            if (isValidIndex(matrix, rows, cols) && matrix[rows, cols] > 0)
            {
                matrix[rows, cols] -= bomb;
            }
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

        public static bool isValidIndex(int[,] matrix, int rows, int cols)
        {
            return rows >= 0 && rows < matrix.GetLength(0)
                && cols >= 0 && cols < matrix.GetLength(1);
        }
    }
}
