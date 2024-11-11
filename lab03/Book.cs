using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Book
    {
        protected string title;
        protected Person author;
        protected DateTime datePublication;

        public Book(string title, Person author, DateTime datePublication)
        { 
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
        }

        public virtual void View()
        {
            Console.WriteLine($"\nTytuł:\t{title}\nAutor:\t");
            author.View();
            Console.WriteLine($"Data wydania:\t{datePublication}");
        }
    }
}
