using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Queue<int> nums = new Queue<int>(numbers.Where(x => x % 2 == 0));

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
