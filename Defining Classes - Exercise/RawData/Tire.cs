using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire()
        {
            TirePressureAndYear = new List<Tire>();
        }

        public Tire(double pressure, int age)
        {
            
            TireAge = age;
            TirePressure = pressure;
        }

        public List<Tire> TirePressureAndYear { get; set; }

        public int TireAge { get; set; }

        public double TirePressure { get; set; }


    }
}
