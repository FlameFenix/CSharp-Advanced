using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                List<string> engineInfo = Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .ToList();

                // "{model} {power} {displacement} {efficiency}"
                Engine currentEngine = new Engine();

                if (engineInfo.Count == 4)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    currentEngine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInfo.Count == 3)
                {
                    string displOrEff = engineInfo[2];
                    if(displOrEff.All(char.IsDigit))
                    {
                        string model = engineInfo[0];
                        int power = int.Parse(engineInfo[1]);
                        int displacement = int.Parse(engineInfo[2]);
                        currentEngine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string model = engineInfo[0];
                        int power = int.Parse(engineInfo[1]);
                        string efficiency = engineInfo[2];
                        currentEngine = new Engine(model, power, efficiency);
                    }
                    
                }
                else if (engineInfo.Count == 2)
                {
                    string model = engineInfo[0];
                    int power = int.Parse(engineInfo[1]);
                    currentEngine = new Engine(model, power);
                }

                engines.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                Car currentCar = new Car();
                Engine currentEngine = new Engine();

                if(carInfo.Length == 2)
                {
                    string model = carInfo[0];
                    string engine = carInfo[1];

                    currentEngine = engines.FirstOrDefault(x => x.Model == engine);
                    currentCar = new Car(model, currentEngine);
                }
                else if(carInfo.Length == 3)
                {
                    string isColor = carInfo[2];

                    if(isColor.All(Char.IsDigit))
                    {
                        string model = carInfo[0];
                        string engine = carInfo[1];
                        int weight = int.Parse(carInfo[2]);

                        currentEngine = engines.FirstOrDefault(x => x.Model == engine);
                        currentCar = new Car(model, currentEngine, weight);
                    }
                    else
                    {
                        string model = carInfo[0];
                        string engine = carInfo[1];
                        string color = carInfo[2];

                        currentEngine = engines.FirstOrDefault(x => x.Model == engine);
                        currentCar = new Car(model, currentEngine, color);
                    }
                    
                }
                else if(carInfo.Length == 4)
                {
                    string model = carInfo[0];
                    string engine = carInfo[1];
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];

                    currentEngine = engines.FirstOrDefault(x => x.Model == engine);
                    currentCar = new Car(model, currentEngine, weight, color);
                }
                cars.Add(currentCar);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
