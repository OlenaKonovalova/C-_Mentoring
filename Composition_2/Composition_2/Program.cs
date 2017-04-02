using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            library.AddBook(new Book("Purple", new Author("Alice", "Walker"), "Long text"));
            library.AddBook(new Book("Kobzar", new Author("Taras", "Shevchenko"), "Long text"));
            library.AddBook(new Book("Godfather", new Author("Mario", "Puzo"), "Long text"));
            library.AddBook(new Book("MyBook", new Author("Olena", "Konovalova"), "Long text"));

            foreach (var book in library.GetBooks())
            {
                Console.WriteLine(book);
            }
        }
    }
}
