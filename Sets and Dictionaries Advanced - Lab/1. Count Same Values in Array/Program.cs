using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], 0);
                }

                dictionary[array[i]] += 1;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
