using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tire)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tire = tire;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tire { get; set; }
    }
}
