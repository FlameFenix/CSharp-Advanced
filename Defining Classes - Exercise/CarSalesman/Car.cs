using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string model, Engine engine) : this()
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, string color) : this()
        {
            Model = model;
            Engine = engine;
            Color = color;
        }

        public Car(string model, Engine engine, int weight) : this()
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }

        public Car(string model, Engine engine, int weight, string color) : this()
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            
            string engine = engine = $"{Model}:" + Environment.NewLine;
            engine += $"{Engine.Model}:" + Environment.NewLine;
            engine += $"Power: {Engine.Power}" + Environment.NewLine;
            if(Engine.Displacement == 0)
            {
                engine += $"Displacement: n/a" + Environment.NewLine;
            }
            else
            {
                engine += $"Displacement: {Engine.Displacement}" + Environment.NewLine;
            }
            if(Engine.Efficiency == null)
            {
                engine += $"Efficiency: n/a" + Environment.NewLine;
            }
            else
            {
                engine += $"Efficiency: {Engine.Efficiency}" + Environment.NewLine;
            }
            if (Weight == 0)
            {
                engine += $"Weight: n/a" + Environment.NewLine;
            }
            else
            {
                engine += $"Weight: {Weight}" + Environment.NewLine;
            }
           if(Color == null)
            {
                engine += $"Color: n/a";
            }
           else
            {
                engine += $"Color: {Color}";
            }
            

            return engine;
        }
    }
}
