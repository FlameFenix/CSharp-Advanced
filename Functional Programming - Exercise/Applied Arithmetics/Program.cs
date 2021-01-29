using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            string command = Console.ReadLine();

            Func<int[], int[]> func;

            Action<int[]> print = null;

            while (command != "end")
            {
                if (command == "add")
                {
                    func = num => num.Select(x => x + 1).ToArray();
                    numbers = func(numbers);
                }
                else if (command == "multiply")
                {
                    func = num => num.Select(x => x * 2).ToArray();
                    numbers = func(numbers);
                }
                else if (command == "subtract")
                {
                    func = num => num.Select(x => x - 1).ToArray();
                    numbers = func(numbers);
                }
                else if (command == "print")
                {
                    print = num => Console.WriteLine(string.Join(" ", num));
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
