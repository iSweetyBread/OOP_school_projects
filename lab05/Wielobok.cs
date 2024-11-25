using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Wielobok : Ksztalt
    {
        public List<Punkt> Wierzcholki { get; set; }

        public Wielobok(string nazwa, List<Punkt> wierzcholki) : base(nazwa)
        {
            if (wierzcholki.Count < 3)
            {
                throw new ArgumentException("Wielobok musi mieć co najmniej 3 wierzchołki");
            }
            Nazwa = nazwa;
            Wierzcholki = wierzcholki;
        }
        public Wielobok() : base()
        {
            Nazwa = "Wielobok Domyślny";
            Wierzcholki = new List<Punkt> { new Punkt("a", -1, 1), new Punkt("a", 1, 1), new Punkt("a", -1, -1), new Punkt("a", 1, -1) };
        }

        public override Wielobok Clone()
        {
            return new Wielobok(Nazwa, Wierzcholki);
        }
        public override double Obwod()
        {
            double obw = 0;
            Console.WriteLine(Wierzcholki.Count);
            for (int i = 1; i < Wierzcholki.Count; i++)
            {
                obw += Punkt.Odleglosc(Wierzcholki[i], Wierzcholki[i - 1]);
            }
            obw += Punkt.Odleglosc(Wierzcholki[0], Wierzcholki.Last());
            return obw;
        }
        public override string ToString()
        {
            string wierz = "";
            foreach (Punkt aaa in Wierzcholki)
            { 
                wierz += "\' " + aaa.ToString() + " \'";
            }
            wierz += " ";
            return "Nazwa: " + Nazwa + "Wierzcholki: " + wierz;
        }
        public override bool Equals(object? obj)
        {
            var item = obj as Wielobok;
            if (this.Wierzcholki.Count != item.Wierzcholki.Count)
            { 
                return false;
            }
            for(int i = 0; i < this.Wierzcholki.Count; i++)
            {
                if (!this.Wierzcholki[i].Equals(item.Wierzcholki[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public override void Przesun(double x, double y)
        {
            foreach (Punkt punkt in Wierzcholki)
            { 
                punkt.Przesun(x, y);
            }
        }
        public void DodajPunkt(Punkt p)
        { 
            this.Wierzcholki.Add(p);
        }

        public static bool operator <(Wielobok wielobok1, Wielobok wielobok2)
        {
            if (wielobok1.Obwod() < wielobok2.Obwod())
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Wielobok wielobok1, Wielobok wielobok2)
        {
            if (wielobok1.Obwod() > wielobok2.Obwod())
            {
                return true;
            }
            return false;
        }
    }
}
