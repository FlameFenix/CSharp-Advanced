using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> characters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(!characters.ContainsKey(input[i]))
                {
                    characters.Add(input[i], 0);
                }

                characters[input[i]]++;
            }

            foreach (var item in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
