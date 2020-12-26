using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();

            Stack<int> stackNumbers = new Stack<int>(numbers);

            string command = string.Empty;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                string currentCommand = cmdArgs[0];

                if(currentCommand == "add")
                {
                    int numberOne = int.Parse(cmdArgs[1]);
                    int numberTwo = int.Parse(cmdArgs[2]);

                    stackNumbers.Push(numberOne);
                    stackNumbers.Push(numberTwo);
                }
                else if(currentCommand == "remove")
                {
                    int removeCount = int.Parse(cmdArgs[1]);

                    if(removeCount < stackNumbers.Count)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }
                }

            }
            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
