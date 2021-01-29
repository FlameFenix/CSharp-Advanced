using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            int n = int.Parse(Console.ReadLine());



            List<int> divisibleNumbers = numbers.Reverse().ToList();

            Predicate<int> predicate = x => x % n == 0;

            Func<List<int>, List<int>> func =
                nums => nums.Where(x => !(predicate(x))).ToList();

            Action<List<int>> action = nums => Console.WriteLine(string.Join(" ", func(nums)));

            action(divisibleNumbers);
            
        }
    }
}
