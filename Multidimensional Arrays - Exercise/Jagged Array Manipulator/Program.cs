using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            string[][] matrix = new string[numberOfRows][];

            FillMatrix(matrix);

            // If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] currentRow = matrix[rows];

                if (rows - 1 >= 0)
                {
                    string[] previousRow = matrix[rows - 1];
                    if (previousRow.Length == currentRow.Length)
                    {
                        for (int cols = 0; cols < currentRow.Length; cols++)
                        {
                            string result = (double.Parse(matrix[rows][cols]) * 2.0).ToString();
                            matrix[rows][cols] = result.ToString();
                        }
                        for (int cols = 0; cols < previousRow.Length; cols++)
                        {
                            string result = (double.Parse(matrix[rows - 1][cols]) * 2.0).ToString();
                            matrix[rows - 1][cols] = result.ToString();
                        }
                    }
                    else
                    {
                        for (int cols = 0; cols < previousRow.Length; cols++)
                        {
                            string result = (double.Parse(matrix[rows - 1][cols]) / 2.0).ToString();
                            matrix[rows - 1][cols] = result.ToString();
                        }

                        for (int cols = 0; cols < currentRow.Length; cols++)
                        {
                            string result = (double.Parse(matrix[rows][cols]) / 2.0).ToString();
                            matrix[rows][cols] = result.ToString();
                        }
                    }
                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                if(cmdArgs.Length == 4)
                {
                    string option = cmdArgs[0];

                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);

                    if (option == "Add")
                    {
                        if (row >= 0 && row < matrix.Length
                        && col >= 0 && col < matrix[row].Length)
                        {

                            double result = double.Parse(matrix[row][col]) + value;
                            matrix[row][col] = result.ToString();
                        }


                    }
                    else if (option == "Subtract")
                    {
                        if (row >= 0 && row < matrix.Length
                         && col >= 0 && col < matrix[row].Length)
                        {
                            double result = double.Parse(matrix[row][col]) - value;
                            matrix[row][col] = result.ToString();
                        }
                    }
                }
            }

            PrintMatrix(matrix);


        }

        public static void FillMatrix(string[][] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
                matrix[rows] = numbers;
            }
        }

        public static void PrintMatrix(string[][] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    Console.Write(matrix[rows][cols] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
