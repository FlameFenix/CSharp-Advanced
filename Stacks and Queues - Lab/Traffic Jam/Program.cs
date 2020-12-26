using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            string command = string.Empty;

            Queue<string> cars = new Queue<string>();

            int countPassedCars = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            countPassedCars++;
                        }

                    }

                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{countPassedCars} cars passed the crossroads.");
        }
    }
}
