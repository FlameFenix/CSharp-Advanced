using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {
        public Box()
        {
            list = new List<T>();
        }

        private List<T> list;

        public int Count { get; set; }

        public void Add(T element)
        {
            list.Add(element);
        }

        public int CompareByValue(T element)
        {
            string currentElement = element.ToString();

            foreach (var value in list)
            {
                if(value.CompareTo(currentElement) > 0)
                {
                    Count++;
                }
            }

            return Count;
        }
    }
}
