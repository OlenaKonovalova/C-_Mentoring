using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_2
{
    public class Author
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}
