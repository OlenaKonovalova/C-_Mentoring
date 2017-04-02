using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions_1
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _age = value;
                }
            }
        }

    }
}
