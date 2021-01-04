using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            HashSet<int> firstGroup = new HashSet<int>();
            HashSet<int> secondGroup = new HashSet<int>();

            for (int i = 0; i < sets[0] + sets[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(i < sets[0])
                {
                    firstGroup.Add(number);
                }
                else
                {
                    secondGroup.Add(number);
                }
            }
            if(firstGroup.Count > 0)
            {
                foreach (var item in firstGroup)
                {
                    if (secondGroup.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            else
            {
                foreach (var item in secondGroup)
                {
                    if(firstGroup.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            
        }
    }
}
