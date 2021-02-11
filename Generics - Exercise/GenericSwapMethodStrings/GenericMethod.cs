using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class GenericMethod<T>
    {

        public GenericMethod()
        {
            list = new List<T>();
        }

        public List<T> list { get; set; }

        public List<T> Swap(int firstIndex, int secondIndex)
        {
            T firstElement = list[firstIndex];
            T secondElement = list[secondIndex];

            list[firstIndex] = secondElement;
            list[secondIndex] = firstElement; 

            return list;
        }

        public override string ToString()
        {
            string output = string.Empty;

            foreach (var item in list)
            {
                output += $"{item.GetType()}: {item}" + Environment.NewLine;
            }

            return output.Trim();
        }
    }
}
