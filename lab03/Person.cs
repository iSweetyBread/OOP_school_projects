using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Person
    {
        private string firstName, lastName;
        private int age;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public virtual void View()
        {
            Console.Write($"|Imie: \t{firstName}|\tNazwisko: \t{lastName}|\tWiek: \t{age}|\t\n");
        }
    }
}
