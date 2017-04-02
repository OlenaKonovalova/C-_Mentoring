using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the Name");
                    person.Name = Console.ReadLine();
                    Console.WriteLine("Enter the Age");
                    person.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (ArgumentNullException argumentNullEx)
                {
                    Console.WriteLine("You SHOULD enter the name");
                    Console.WriteLine("Try again");
                }
                catch (ArgumentException argExeption)
                {
                    Console.WriteLine("Your age CANNOT be negative");
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}
