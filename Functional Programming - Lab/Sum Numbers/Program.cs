using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Func<int[], int> func = sumNumbers;
            Func<int[], int> count = countNumbers;

            Console.WriteLine(count(numbers));
            Console.WriteLine(func(numbers));
            
        }

        static int sumNumbers(int[] numbers)
        {
            int sum = numbers.Sum();

            return sum;
        }

        static int countNumbers(int[] numbers)
        {
            int count = numbers.Length;
            return count;
        }
    }
}