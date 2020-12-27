using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int addNumbers = numbers[0];
            int removeNumbers = numbers[1];
            int existingNumber = numbers[2];

            int[] sequence = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            Queue<int> queueNumbers = new Queue<int>();

            for (int i = 0; i < addNumbers; i++)
            {
                queueNumbers.Enqueue(sequence[i]);
            }

            for (int i = 0; i < removeNumbers; i++)
            {
                queueNumbers.Dequeue();
            }

            if(queueNumbers.Contains(existingNumber))
            {
                Console.WriteLine(queueNumbers.Contains(existingNumber)
                                              .ToString()
                                              .ToLower());
            }
            else
            {
                if(queueNumbers.Count > 0)
                {
                    Console.WriteLine(queueNumbers.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
