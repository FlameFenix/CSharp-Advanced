﻿using System;
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
            return new LibraryIterator(BooksList);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        private class LibraryIterator : IEnumerator<Book>
        {
            public LibraryIterator(List<Book> books)
            {
                booksList = books;
            }

            public List<Book> booksList { get; set; }

            private int currentIndex = -1;

            public Book Current => booksList[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {

                return ++currentIndex < booksList.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
