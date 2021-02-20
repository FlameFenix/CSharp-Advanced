using System;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rowsSize = matrixSize[0];
            int colsSize = matrixSize[1];

            char[,] matrix = new char[rowsSize, colsSize];

            int[] currentPosition = new int[2];

            FillMatrix(matrix, currentPosition);

            string directions = Console.ReadLine();
            char[] directionsToChar = directions.ToCharArray();
            bool isDead = false;
            bool isWin = false;

            for (int i = 0; i < directionsToChar.Length; i++)
            {
                char currentDirection = directionsToChar[i];
                int rows = currentPosition[0];
                int cols = currentPosition[1];

                matrix[rows, cols] = '.';

                if (currentDirection == 'U')
                {
                    rows -= 1;
                }
                else if (currentDirection == 'D')
                {
                    rows += 1;
                }
                else if (currentDirection == 'L')
                {
                    cols -= 1;
                }
                else if (currentDirection == 'R')
                {
                    cols += 1;
                }

                if(isIndexValid(matrix, rows, cols))
                {
                    if(matrix[rows, cols] == 'B')
                    {
                        currentPosition[0] = rows;
                        currentPosition[1] = cols;
                        isDead = true;
                    }

                    else if(matrix[rows, cols] == '.')
                    {
                        currentPosition[0] = rows;
                        currentPosition[1] = cols;
                        matrix[rows, cols] = 'P';
                    }

                    BunniesPolinate(matrix);

                    if(matrix[rows,cols] == 'B')
                    {
                        isDead = true;
                        break;
                    }
                }
                else
                {
                    BunniesPolinate(matrix);
                    isWin = true;
                }

                if (isDead || isWin)
                {
                    break;
                }
            }

            PrintMatrix(matrix);
            if(isDead)
            {
                Console.WriteLine($"dead: {currentPosition[0]} {currentPosition[1]}");
            }
            else if(isWin)
            {
                Console.WriteLine($"won: {currentPosition[0]} {currentPosition[1]}");
            }
        }

        private static void BunniesPolinate(char[,] matrix)
        {
            string[] bunnyCordinates = new string[] { };

            bunnyCordinates = CheckBunnie(matrix, bunnyCordinates);

            for (int j = 0; j < bunnyCordinates.Length; j++)
            {
                int[] currentCoords = bunnyCordinates[j].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bunnyRow = currentCoords[0];
                int bunnyCol = currentCoords[1];

                if (isIndexValid(matrix, bunnyRow + 1, bunnyCol))
                {
                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }
                if (isIndexValid(matrix, bunnyRow - 1, bunnyCol))
                {
                    matrix[bunnyRow - 1, bunnyCol] = 'B';

                }
                if (isIndexValid(matrix, bunnyRow, bunnyCol + 1))
                {
                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }
                if (isIndexValid(matrix, bunnyRow, bunnyCol - 1))
                {
                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }
            }
        }

        private static bool isIndexValid(char[,] matrix, int rows, int cols)
        {
            if (rows >= 0 && rows < matrix.GetLength(0)
                                        && cols >= 0 && cols < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string[] CheckBunnie(char[,] matrix, string[] coordinates)
        {
            string cords = string.Empty;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if(matrix[rows,cols] == 'B')
                    {
                        cords += $"{rows} {cols}, ";
                    }
                    
                }
            }
            coordinates = cords.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            return coordinates;
            
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static void FillMatrix(char[,] matrix, int[] currentPosition)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string currentLine = Console.ReadLine();
                char[] input = currentLine.ToCharArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                    if (matrix[rows, cols] == 'P')
                    {
                        currentPosition[0] = rows;
                        currentPosition[1] = cols;
                    }
                }
            }
        }
    }
}
