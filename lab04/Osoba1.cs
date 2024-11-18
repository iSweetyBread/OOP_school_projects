using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class Osoba1 : IOsoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba1(string imie, string nazwisko)
        { 
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void ZwrocPelnaNazwe()
        { 
            Console.WriteLine($"{Imie} {Nazwisko}");
        }
    }
}
