using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            string evenOrOdd = Console.ReadLine();

            int start = range[0];
            int end = range[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = x => true;

            if (evenOrOdd == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else if (evenOrOdd == "odd")
            {
                predicate = x => x % 2 != 0;
            }

            Action<List<int>> print =
                x => Console.WriteLine(string.Join(" ", x.Where(x => predicate(x))));

            print(numbers);

        }
    }
}
