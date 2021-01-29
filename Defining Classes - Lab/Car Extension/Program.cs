using System;
using Car_Extension;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Make = "VW";
            newCar.Model = "MK3";
            newCar.Year = 1992;
            newCar.FuelConsumption = 200;
            newCar.FuelQuantity = 200;
            newCar.Drive(2000);
            Console.WriteLine(newCar.WhoAmI());
        }
    }
}
