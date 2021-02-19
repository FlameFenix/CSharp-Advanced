using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIteratorTask
{
    public class ListyIterator<T> : IEnumerable<T> , IEnumerator<T>
    {
        public List<T> Elements { get; set; }

        internal int Index = 0;

        public T Current => Elements[Index];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public void Create(List<T> elements)
        {
            Elements = elements.ToList();
        }

        public bool MoveNext()
        {
            bool isTrue = Index + 1 < Elements.Count ? true : false;

            if (isTrue)
            {
                Index++;
            }

            return isTrue;
        }

        public void Print()
        {

            try
            {
                Console.WriteLine($"{Elements[Index]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid Operation!");
                throw;
            }
        }

        public bool HasNext()
        {
            bool isTrue = Index + 1 < Elements.Count ? true : false;

            return isTrue;
        }

        public void Reset()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in Elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }
}
