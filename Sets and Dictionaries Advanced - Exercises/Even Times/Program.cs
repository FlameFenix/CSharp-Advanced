using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if(!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var item in numbers.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
                break;
            }
        }
    }
}
