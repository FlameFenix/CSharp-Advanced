using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperionts = int.Parse(Console.ReadLine());

            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < numberOfOperionts; i++)
            {
                int[] numberCommand = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .Select(int.Parse)
                                             .ToArray();
                int currentCommand = numberCommand[0];

                if(currentCommand == 1) // Add
                {
                    int number = numberCommand[1];

                    stackNumbers.Push(number);
                }
                else if(currentCommand == 2) // Delete
                {
                    if(stackNumbers.Count > 0)
                    {
                        stackNumbers.Pop();
                    }
                }
                else if(currentCommand == 3) // Max element 
                {
                    if(stackNumbers.Count > 0)
                    {
                        Console.WriteLine(stackNumbers.Max());
                    }
                    
                }
                else if(currentCommand == 4) // Min element
                {
                    if(stackNumbers.Count > 0)
                    {
                        Console.WriteLine(stackNumbers.Min());
                    }
                }
            }

            if(stackNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stackNumbers));
            }
            
        }
    }
}
