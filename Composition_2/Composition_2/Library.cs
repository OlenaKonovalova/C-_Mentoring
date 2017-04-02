using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_2
{
    public class Library
    {
        private List<Book> _library;

        public Library()
        {
            _library = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _library.Add(book);
        }
        public void DeleteBook(Book book)
        {
            _library.Remove(book);
        }
        public IEnumerable<Book> GetBooks()
        {
            return _library;
        }

    }
}
