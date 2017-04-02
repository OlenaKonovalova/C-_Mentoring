using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_2
{
    public class Book
    {
        public string Name { get; private set; }
        public Author AuthorInstance { get; private set; }
        public string Text { get; private set; }

        public Book(string name, Author author, string text)
        {
            Name = name;
            AuthorInstance = author;
            Text = text;
        }

        public override string ToString()
        {
            return Name + " " + AuthorInstance.ToString();
        }

    }
}
