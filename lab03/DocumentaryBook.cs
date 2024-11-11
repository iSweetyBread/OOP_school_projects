using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class DocumentaryBook : Book
    {
        protected int pages;
        protected string topic;

        public DocumentaryBook(string title, Person author, DateTime datePublication, int pages, string topic) : base(title, author, datePublication)
        {
            this.title = title;
            this.author = author;
            this.datePublication = datePublication;
            this.pages = pages;
            this.topic = topic;
        }

        public override void View()
        {
            Console.WriteLine($"\nTytuł:\t{title}\nAutor:\t");
            author.View();
            Console.WriteLine($"Data wydania:\t{datePublication}\nLiczba Stron:\t{pages}\nTemat: {topic}");
        }
    }
}
