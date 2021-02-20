using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            string[] directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            char[][] matrix = new char[sizeOfField][];

            int[] currentPosition = new int[3];

            FillMatrix(sizeOfField, matrix, currentPosition);

            int numberOfCoals = currentPosition[2];

            int coals = 0;

            bool isGameOver = false;
            bool isCoalsReached = false;

            for (int i = 0; i < directions.Length; i++)
            {
                int rows = currentPosition[0];
                int cols = currentPosition[1];

                if (directions[i] == "up")
                {
                    rows -= 1;
                }
                else if (directions[i] == "down")
                {
                    rows += 1;
                }
                else if (directions[i] == "left")
                {
                    cols -= 1;
                }
                else if (directions[i] == "right")
                {
                    cols += 1;
                }

                if(CheckIndex(matrix, rows, cols))
                {
                    currentPosition[0] = rows;
                    currentPosition[1] = cols;

                    if (matrix[rows][cols] == 'e')
                    {
                        isGameOver = true;
                        break;
                    }
                    else if (matrix[rows][cols] == 'c')
                    {
                        coals++;
                        matrix[rows][cols] = '*';
                    }
                }

                if(coals == numberOfCoals)
                {
                    isCoalsReached = true;
                    break;
                }
            }
       
            if (isCoalsReached)
            {
                Console.WriteLine($"You collected all coals! ({currentPosition[0]}, {currentPosition[1]})");
            }
            else if (isGameOver)
            {
                Console.WriteLine($"Game over! ({currentPosition[0]}, {currentPosition[1]})");
            }
            else
            {
                Console.WriteLine($"{numberOfCoals - coals} coals left. ({currentPosition[0]}, {currentPosition[1]})");
            }
        }

        private static bool CheckIndex(char[][] matrix, int rows, int cols)
        {
            if (rows >= 0 && rows < matrix.Length
                                && cols >= 0 && cols < matrix[rows].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillMatrix(int sizeOfField, char[][] matrix, int[] currentPosition)
        {
            for (int rows = 0; rows < sizeOfField; rows++)
            {
                string currentLine = Console.ReadLine().Replace(" ", "");
                char[] currentCharLine = currentLine.ToCharArray();
                matrix[rows] = currentCharLine;

                for (int cols = 0; cols < matrix[rows].Length; cols++)
                {
                    if (matrix[rows][cols] == 's')
                    {
                        currentPosition[0] = rows;
                        currentPosition[1] = cols;
                    }
                    else if(matrix[rows][cols] == 'c')
                    {
                        currentPosition[2]++;
                    }
                }
            }
        }
    }
}
