using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            
            Queue<string> team = new Queue<string>(names);

            int rotations = int.Parse(Console.ReadLine());

            while (team.Count != 1)
            {
                for (int i = 1; i < rotations; i++)
                {
                    team.Enqueue(team.Dequeue());
                }
                Console.WriteLine($"Removed {team.Dequeue()}");
            }

            Console.WriteLine($"Last is {string.Join(Environment.NewLine, team)}");
        }
    }
}
