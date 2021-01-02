using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string currentCommand = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                bool isValueSet = false;

                if (currentCommand == "Add")
                {

                    for (int rows = 0; rows < matrix.Length; rows++)
                    {
                        for (int cols = 0; cols < matrix[rows].Length; cols++)
                        {
                            if (row == rows && col == cols)
                            {
                                matrix[row][col] += value;
                                isValueSet = true;
                                break;
                            }
                        }
                    }
                }
                else if(currentCommand == "Subtract")
                {
                    for (int rows = 0; rows < matrix.Length; rows++)
                    {
                        for (int cols = 0; cols < matrix[rows].Length; cols++)
                        {
                            if (row == rows && col == cols)
                            {
                                matrix[row][col] -= value;
                                isValueSet = true;
                                break;
                            }
                        }
                    }
                }

                if(!isValueSet)
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            for (int rows = 0; rows < matrix.Length; rows++)
            {
                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    Console.Write($"{matrix[rows][cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
