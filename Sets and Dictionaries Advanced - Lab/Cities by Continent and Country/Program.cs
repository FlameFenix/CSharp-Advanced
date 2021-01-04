using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfContinents = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfContinents; i++)
            {

                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsCountriesCities.ContainsKey(continent) )
                {
                    continentsCountriesCities.Add(continent, new Dictionary<string, List<string>>());
                    
                }

                if(!continentsCountriesCities[continent].ContainsKey(country))
                {
                    continentsCountriesCities[continent].Add(country, new List<string>());
                }
                
                continentsCountriesCities[continent][country].Add(city);
            }

            foreach (var continent in continentsCountriesCities)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var county in continent.Value)
                {
                    Console.WriteLine($"{county.Key} -> {string.Join(", ", county.Value)}");
                }
            }
        }
    }
}
