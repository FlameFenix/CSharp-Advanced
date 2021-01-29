using System;

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

            Console.WriteLine($"Make: {newCar.Make}\nModel: {newCar.Model}\nYear: {newCar.Year}");
        }
    }
}
