using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string currentRow = reader.ReadLine();

                int counter = 0;

                while (currentRow != null)
                {
                    counter++;

                    if(counter % 2 == 0)
                    {
                        Console.WriteLine(currentRow);                        
                    }

                    currentRow = reader.ReadLine();
                }
            }
        }
    }
}
