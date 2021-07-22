using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Classes
{
    class Library : ILibrary
    {
        private Dictionary<string, Book> Shelf = new Dictionary<string, Book>();

        public int Count => throw new NotImplementedException();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(firstName, lastName, title);
            Shelf.Add(book.title, book);
        }

        public Book Borrow(string title)
        {
            Book book = new Book();
            Shelf.TryGetValue(title, out book);
            Shelf.Remove(title);
            return book;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Return(Book book)
        {
            Shelf.Add(book.title, book);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
