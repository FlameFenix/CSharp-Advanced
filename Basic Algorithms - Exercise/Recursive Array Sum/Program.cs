using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int sum = Sum(array, 0);

            Console.WriteLine(sum);
        }

        private static int Sum(int[] array, int index)
        {
            int sum = 0;
            
            if(index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + Sum(array, index + 1);
        }
    }
    
}
