using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine()
        {

        }
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;

        }

        public Engine (string model, int power, int displacement, string efficiency) : this(model, power, displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        
    }
}
