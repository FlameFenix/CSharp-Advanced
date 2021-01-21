using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(decimal.Parse)
                                      .ToArray();

            Func<decimal[], decimal[]> vat = AddVat;

            foreach (var item in vat(prices))
            {
                Console.WriteLine($"{item:f2}");
            }
        }

        public static decimal[] AddVat(decimal[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] *= 1.2m;
            }

            return prices;
        }
    }
}
