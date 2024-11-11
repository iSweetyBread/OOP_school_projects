using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class AdventureBook : Book
    {
        protected int pages;
        protected bool happyEnd;

        public AdventureBook(string title, Person author, DateTime datePublication, int pages, bool happyEnd) : base(title, author, datePublication) 
        { 
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
            this.pages = pages;
            this.happyEnd = happyEnd;
        }

        public override void View()
        {
            Console.WriteLine($"\nTytuł:\t{title}\nAutor:\t");
            author.View();
            Console.WriteLine($"Data wydania:\t{datePublication}\nLiczba Stron:\t{pages}Szczęśliwa zakończenie: {happyEnd}");
        }
    }
}
