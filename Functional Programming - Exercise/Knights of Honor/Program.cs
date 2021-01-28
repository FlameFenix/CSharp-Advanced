using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(x => x = "Sir " + x)
                                    .ToArray();

            Action<string[]> print =
                name => Console.WriteLine(string.Join(Environment.NewLine, name));

            print(names);
        }
    }
}
