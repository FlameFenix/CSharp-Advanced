using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequenceNumber = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

            int target = int.Parse(Console.ReadLine());

            Stack<int> stackNumbers = new Stack<int>(sequenceNumber);

            int sumNumbers = 0;

            int countRack = 0;

            while (stackNumbers.Count > 0)
            {
                int currentNumber = stackNumbers.Peek();

                if (sumNumbers + currentNumber > target)
                {
                    sumNumbers = 0;
                    countRack++;
                }
                else if (sumNumbers + currentNumber == target)
                {
                    sumNumbers = 0;
                    countRack++;
                    stackNumbers.Pop();
                }
                else
                {
                    sumNumbers += stackNumbers.Pop();
                }


            }

            if (sumNumbers != 0)
            {
                countRack++;
            }

            Console.WriteLine(countRack);

        }
    }
}
