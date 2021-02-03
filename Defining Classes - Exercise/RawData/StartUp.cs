using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
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

                //   Car currentCar = new Car();
                // model
                string model = carInfo[0];

                // engine
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                // cargo

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                Cargo cargo = new Cargo(cargoType, cargoWeight);

                // tires

                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);

                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);

                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);

                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                List<Tire> tires = new List<Tire>();

                Tire tireOne = new Tire(tire1Pressure, tire1Age);
                Tire tireTwo = new Tire(tire2Pressure, tire2Age);
                Tire tireThree = new Tire(tire3Pressure, tire3Age);
                Tire tireFour = new Tire(tire4Pressure, tire4Age);

                tires.Add(tireOne);
                tires.Add(tireTwo);
                tires.Add(tireThree);
                tires.Add(tireFour);

                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if(command == "fragile")
            {
                foreach (var item in cars.Where(x => x.Cargo.Type == "fragile"))
                {
                    foreach (var tire in item.Tire)
                    {
                        if(tire.TirePressure < 1)
                        {
                            Console.WriteLine(item.Model);
                            break;
                        }
                    }

                }
                   // •	"fragile" - print all cars whose cargo is "fragile" with a tire, whose pressure is < 1
            }
            else if(command == "flamable")
            {
                foreach (var item in cars.Where(x => x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(item.Model);
                }
                // •	"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
            }
        }
    }
}
