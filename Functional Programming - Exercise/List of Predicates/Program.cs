using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            List<int> finalNumbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    Predicate<int> predicate = x => x % numbers[j] == 0;

                    if(predicate(i))
                    {
                        count++;
                        if(count == numbers.Length)
                        {
                            finalNumbers.Add(i);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", finalNumbers));
        }
    }
}
