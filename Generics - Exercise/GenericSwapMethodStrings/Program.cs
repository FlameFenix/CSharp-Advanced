using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            GenericMethod<string> generic = new GenericMethod<string>();

            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();

                generic.list.Add(name);
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
