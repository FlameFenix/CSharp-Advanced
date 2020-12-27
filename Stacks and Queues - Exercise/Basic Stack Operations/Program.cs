using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int nNumbers = numbers[0];
            int popNumbers = numbers[1];
            int existingElement = numbers[2];

            int[] sequence = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < nNumbers; i++)
            {
                stackNumbers.Push(sequence[i]);
            }

            for (int i = 0; i < popNumbers; i++)
            {
                stackNumbers.Pop();
            }

            if(stackNumbers.Contains(existingElement))
            {
                Console.WriteLine(stackNumbers.Contains(existingElement)
                                              .ToString()
                                              .ToLower());
            }
            else
            {
                if(stackNumbers.Count > 0)
                {
                    Console.WriteLine(stackNumbers.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
               
            }
        }
    }
}
