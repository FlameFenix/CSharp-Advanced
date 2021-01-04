using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> parking = new HashSet<string>();

            while (input != "END")
            {
                string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string option = cmdArgs[0];
                string number = cmdArgs[1];
                if(option == "IN")
                {
                    parking.Add(number);
                }
                else if(option == "OUT")
                {
                    parking.Remove(number);
                }

                input = Console.ReadLine();
            }
            if(parking.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var cars in parking)
            {
                Console.WriteLine(cars);
            }
        }
    }
}
