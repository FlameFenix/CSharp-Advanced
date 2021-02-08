using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public Box()
        {
            List = new List<T>();
        }

        public List<T> List { get; set; }

        public void Add(T element)
        {
            List.Add(element);
        }

        public override string ToString()
        {
            string output = string.Empty;

            foreach (var item in List)
            {
                output += $"{item.GetType()}: {item}" + Environment.NewLine;
            }
            return output;     
        }
    }
}
