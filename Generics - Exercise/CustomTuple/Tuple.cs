using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTuple
{
    public class Tuple<TFirst, TSecond>
    {
        public TFirst FirstTuple { get; set; }

        public TSecond SecondTuple { get; set; }

        public Tuple(TFirst firstElement, TSecond secondElement)
        {
            FirstTuple = firstElement;
            SecondTuple = secondElement;
        }

        public override string ToString()
        {
            return $"{FirstTuple} -> {SecondTuple}";
        }
    }
}
