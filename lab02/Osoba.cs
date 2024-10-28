using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public string Imie
        {
            get { return imie; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Imie musi mieć co najmniej 2 znaki");
                }
                imie = value;
            }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException($"Imie musi mieć co najmniej 2 znaki");
                }
                nazwisko = value;
            }
        }
        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (wiek <= 0)
                {
                    throw new ArgumentException("Wiek musi być liczbą dodatnią");
                }
                wiek = value;
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Osoba nazywa się: {imie} {nazwisko}, ma {wiek} lat");
        }
    }
}
