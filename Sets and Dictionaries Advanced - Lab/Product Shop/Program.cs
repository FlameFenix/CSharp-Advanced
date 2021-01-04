using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string shop = cmdArgs[0];
                string food = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if(!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop].Add(food, price);


                input = Console.ReadLine();
            }

            foreach (var item in shops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
