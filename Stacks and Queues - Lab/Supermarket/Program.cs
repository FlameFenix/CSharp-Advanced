using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            Queue<string> customers = new Queue<string>();

            while ((name = Console.ReadLine()) != "End")
            {
                if(name == "Paid")
                {
                    for (int i = 0; i <= customers.Count; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                        i = 0;
                    }
                }
                else
                {
                    customers.Enqueue(name);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
