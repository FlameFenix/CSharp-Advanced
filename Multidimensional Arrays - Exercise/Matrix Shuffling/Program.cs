using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            FillMatrix(matrix);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                if(cmdArgs.Length == 5)
                {
                    string option = cmdArgs[0];
                    int rowFirstElement = int.Parse(cmdArgs[1]);
                    int colFirstElement = int.Parse(cmdArgs[2]);
                    int rowSecondElement = int.Parse(cmdArgs[3]);
                    int colSecondElement = int.Parse(cmdArgs[4]);

                    if(rowFirstElement < matrix.GetLength(0)
                    && rowSecondElement < matrix.GetLength(0)
                    && colFirstElement < matrix.GetLength(1)
                    && colSecondElement < matrix.GetLength(1))
                    {
                        string firstElement = matrix[rowFirstElement, colFirstElement];
                        string secondElement = matrix[rowSecondElement, colSecondElement];

                        matrix[rowFirstElement, colFirstElement] = secondElement;
                        matrix[rowSecondElement, colSecondElement] = firstElement;

                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                } 
            }
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

        public static void PrintMatrix(string[,] matrix)
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
