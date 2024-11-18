using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string imie, string nazwisko, string kierunek, int rok, int semestr, string uczelnia = "WSIiZ") : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = "WSIiZ";
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return Imie + " " + Nazwisko + " - " + Semestr.ToString() + Kierunek + " " + Rok.ToString() + " " + "WSIiZ";
        }
    }
}
