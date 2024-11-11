using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnoscSilnika;
        private int iloscOsob;

        public double Waga
        {
            get { return waga; }
            set
            {
                if (value < 2 || value > 4.5)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "liczba musi być między 2 a 4.5");
                }
                waga = value;
            }
        }
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set
            {
                if (value < 0.8 || value > 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "liczba musi być między 0.8 a 3");
                }
                pojemnoscSilnika = value;
            }
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg, double waga, double pojemnoscSilnika, int iloscOsob) : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            this.marka = marka;
            this.model = model;
            this.nadwozie = nadwozie;
            this.kolor = kolor;
            this.rokProdukcji = rokProdukcji;
            this.przebieg = przebieg;
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            this.iloscOsob = iloscOsob;
        }

        public override void info()
        {
            Console.WriteLine($"Informacje o samochodzie:\n\tMarka: {marka}\n\tModel: {model}\n\tNadwozie: {nadwozie}\n\tKolor: {kolor}\n\tRok Produkcji: {rokProdukcji}\n\tPrzebieg: {przebieg} km\n\tWaga: {waga} t\n\tPojemność silnika: {pojemnoscSilnika}\n\tIlość osób: {iloscOsob}\n");
        }
    }
}
