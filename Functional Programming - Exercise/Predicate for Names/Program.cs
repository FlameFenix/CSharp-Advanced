using System;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSymbols = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Where(x => x.Length <= numberOfSymbols)
                                    .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
