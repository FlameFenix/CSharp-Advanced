using GenericSwapMethodStrings;
using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GenericMethod<int> generic = new GenericMethod<int>();

            for (int i = 0; i < n; i++)
            {

                int number = int.Parse(Console.ReadLine());

                generic.list.Add(number);
            }

            int[] indexes = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            generic.Swap(indexes[0], indexes[1]);

            Console.WriteLine(generic.ToString());
        }
    }
}
