using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override void ViewBook()
        {
            Random rnd = new Random();
            Console.WriteLine($"Czytelnik {FirstName} {LastName} przeczytał:");
            foreach (Book book in booksRead)
            {
                book.View();
                Console.WriteLine($"Ocena książki: {rnd.Next(1, 11)}\n");
            }
        }

        public override void View()
        {
            Console.WriteLine($"|Imie: \t{FirstName}|\tNazwisko: \t{LastName}|\tWiek: \t{Age}|\t\n");
            this.ViewBook();
        }
    }
}
