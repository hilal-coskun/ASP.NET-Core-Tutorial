using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Hilal"},
                new Student{ FirstName="Emine"},
                new Person{FirstName="Coskun"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
        }


        class Customer : Person
        {
            public String City { get; set; }
        }

        class Student : Person
        {
            public String Department { get; set; }
        }
    }
}
