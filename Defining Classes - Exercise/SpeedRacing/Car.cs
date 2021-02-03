using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string carmodel, double fuelAmount, double fuelConsump)
        {
            CarModel = carmodel;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsump;
            TravelledDistance = 0;
        }

        public string CarModel { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelledDistance { get; set; }

        public static void CarDriving(double distanceToTravel, Car car)
        {
            double fuelToReduce = distanceToTravel * car.FuelConsumptionPerKm;

            string insufficient = string.Empty;

            if(car.FuelAmount - fuelToReduce >= 0)
            {
                car.FuelAmount -= fuelToReduce;
                car.TravelledDistance += distanceToTravel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
