using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClothes = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfClothes; i++)
            {
                // Blue -> dress,jeans,hat

                string[] input = Console.ReadLine()
                                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();


                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentClothes = clothes[j];
                    if (!wardrobe[color].ContainsKey(currentClothes))
                    {
                        wardrobe[color].Add(currentClothes, 0);
                    }

                    wardrobe[color][currentClothes]++;
                }

            }

            string[] colorAndClothing = Console.ReadLine()
                                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();
            string colorNeeded = colorAndClothing[0];
            string clothNeeded = colorAndClothing[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    if (color.Key == colorNeeded && cloth.Key == clothNeeded)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }
            }
        }
    }
}
