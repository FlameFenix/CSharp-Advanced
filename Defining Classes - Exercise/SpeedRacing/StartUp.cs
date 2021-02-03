using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string carModel = carInfo[0];
                double FuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carInfo[2]);

                Car currentCar = new Car(carModel, FuelAmount, fuelConsumptionPerKm);

                cars.Add(currentCar);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string option = cmdArgs[0];
                string carModel = cmdArgs[1];
                double distance = double.Parse(cmdArgs[2]);

                Car currentCar = cars.FirstOrDefault(x => x.CarModel == carModel);

                if (cars.Contains(currentCar))
                {
                    Car.CarDriving(distance, currentCar);
                }
                else
                {

                }
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.CarModel} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
