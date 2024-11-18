using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Student : IStudent
    {
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr) 
        { 
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string WypiszPelnaNazweIUczelnie()
        { 
            return Imie + " " + Nazwisko + " - " + Semestr.ToString() + Kierunek + " " + Rok.ToString() + " " + Uczelnia;
        }
    }
}
