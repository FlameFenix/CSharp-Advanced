using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<string> stackPumps = new Queue<string>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                string info = Console.ReadLine();
                stackPumps.Enqueue(info + $" {i}");
            }

            int totalFuel = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {
                string currentPump = stackPumps.Dequeue();

                int[] cmdArgs = currentPump.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

                int fuel = cmdArgs[0];
                int distance = cmdArgs[1];
                int index = cmdArgs[2];

                totalFuel += fuel;

                if (totalFuel - distance < 0)
                {
                    i = -1;
                    totalFuel = 0;
                }
                else
                {
                    totalFuel -= distance;
                }

                stackPumps.Enqueue(currentPump);
            }

            string[] firstPump = stackPumps.Dequeue()
                                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();

            int bestIndex = int.Parse(firstPump[2]);

            Console.WriteLine(bestIndex);
        }
    }
}
