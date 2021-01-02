using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[][] pascal = new long[numberOfRows][];
            int cols = 1;

            for (int rows = 0; rows < pascal.Length; rows++)
            {
                pascal[rows] = new long[cols];
                pascal[rows][0] = 1;
                pascal[rows][pascal[rows].Length - 1] = 1;
                cols++;

                if(rows > 1)
                {
                    for (int col = 1; col < pascal[rows].Length - 1; col++)
                    {
                        long[] prevRow = pascal[rows - 1];
                        long firstNumber = prevRow[col];
                        long secondNumber = prevRow[col - 1];
                        pascal[rows][col] = firstNumber + secondNumber;
                    }
                }
            }

            for (int rows = 0; rows < pascal.Length; rows++)
            {
                for (int col = 0; col < pascal[rows].Length; col++)
                {
                    Console.Write(pascal[rows][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
