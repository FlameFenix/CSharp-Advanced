using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> BooksList { get; set; }

        public Library(params Book[] books)
        {
            BooksList = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return BooksList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
