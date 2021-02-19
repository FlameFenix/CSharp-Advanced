using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeupleTask
{
    class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Tfirst FirstElement { get; set; }

        public Tsecond SecondElement { get; set; }

        public Tthird ThirdElement { get; set; }

        public Threeuple(Tfirst first, Tsecond second, Tthird third)
        {
            FirstElement = first;
            SecondElement = second;
            ThirdElement = third;
        }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement} -> {ThirdElement}";
        }
    }
}
