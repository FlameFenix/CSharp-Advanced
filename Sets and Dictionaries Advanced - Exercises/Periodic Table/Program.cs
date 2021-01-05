using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            HashSet<string> something = new HashSet<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    something.Add(input[j]);
                }
            }

            foreach (var item in something.OrderBy(x => x))
            {
                Console.Write($"{item} ");
            }

        }

    }
}
