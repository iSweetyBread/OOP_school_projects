using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Reader : Person
    {
        protected List<Book> booksRead = new List<Book>();

        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public void AddBook(Book book)
        {
            booksRead.Add(book);
        }

        public virtual void ViewBook()
        {
            Console.WriteLine($"\nCzytelnik {FirstName} {LastName} przeczytał:");
            foreach (Book book in booksRead)
            {
                book.View();
            }
        }

        public override void View()
        {
            Console.Write($"|Imie: \t{FirstName}|\tNazwisko: \t{LastName}|\tWiek: \t{Age}|\t");
            ViewBook();
        }
    }
}
