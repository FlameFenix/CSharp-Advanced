using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[sizeOfField, sizeOfField];

            FillMatrix(chessBoard);

            
            int countReplaced = 0;
            int MaxAttacks = 0;

            int attackerRow = 0;
            int attackerCol = 0;

            while (true)
            {
                for (int rows = 0; rows < chessBoard.GetLength(0); rows++)
                {
                    int countAttacks = 0;

                    for (int cols = 0; cols < chessBoard.GetLength(1); cols++)
                    {
                        char currentPosition = chessBoard[rows, cols];
                        if (currentPosition == 'K')
                        {
                            countAttacks = Attacks(chessBoard, rows, cols);
                            if(countAttacks > MaxAttacks)
                            {
                                MaxAttacks = countAttacks;
                                attackerRow = rows;
                                attackerCol = cols;
                            }
                        }
                    }
                }

                if(MaxAttacks > 0)
                {
                    chessBoard[attackerRow, attackerCol] = '0';
                    MaxAttacks = 0;
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }

        private static int Attacks(char[,] chessBoard, int rows, int cols)
        {
            int countAttacks = 0;

            if (indexValidation(chessBoard, rows - 2, cols - 1) == true)
            {
                if (chessBoard[rows - 2, cols - 1] == 'K')
                {
                    countAttacks++;
                }
            }
            if (indexValidation(chessBoard, rows - 2, cols + 1) == true)
            {
                if (chessBoard[rows - 2, cols + 1] == 'K')
                {
                    countAttacks++;
                }

            }
            if (indexValidation(chessBoard, rows - 1, cols - 2) == true)
            {
                if (chessBoard[rows - 1, cols - 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (indexValidation(chessBoard, rows - 1, cols + 2) == true)
            {
                if (chessBoard[rows - 1, cols + 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (indexValidation(chessBoard, rows + 1, cols - 2) == true)
            {
                if (chessBoard[rows + 1, cols - 2] == 'K')
                {
                    countAttacks++;
                }
            }
            if (indexValidation(chessBoard, (rows + 1), (cols + 2)) == true)
            {
                if (chessBoard[rows + 1, cols + 2] == 'K')
                {
                    countAttacks++;
                }

            }
            if (indexValidation(chessBoard, rows + 2, cols + 1) == true)
            {
                if (chessBoard[rows + 2, cols + 1] == 'K')
                {
                    countAttacks++;
                }
            }
            if (indexValidation(chessBoard, rows + 2, cols - 1) == true)
            {
                if (chessBoard[rows + 2, cols - 1] == 'K')
                {
                    countAttacks++;
                }
            }

            return countAttacks;
        }

        public static bool indexValidation(char[,] chessboard, int row, int col)
        {
            if (row >= 0 && row < chessboard.GetLength(0) &&
                col >= 0 && col < chessboard.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static char[,] FillMatrix(char[,] matrix)
        {

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string characters = Console.ReadLine();
                char[] charArray = characters.ToCharArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {

                    matrix[rows, cols] = charArray[cols];
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
                    Console.Write(matrix[rows, cols] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
