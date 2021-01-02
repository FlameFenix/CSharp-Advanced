using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                string chars = Console.ReadLine();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = chars[cols].ToString();
                }
            }

            string character = Console.ReadLine();

            bool isCharExist = false;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (character == matrix[rows, cols])
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        isCharExist = true;
                        break;
                    }
                }
                if(isCharExist)
                {
                    break;
                }
            }

            if(!isCharExist)
            {
                Console.WriteLine($"{character} does not occur in the matrix");
            }
        }
    }
}
