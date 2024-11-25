using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Trojkat : Wielobok
    {
        public Trojkat(string nazwa, Punkt p1, Punkt p2, Punkt p3) : base(nazwa, new List<Punkt> { p1, p2, p3 })
        {
            Nazwa = nazwa;
            Wierzcholki[0] = p1;
            Wierzcholki[1] = p2;
            Wierzcholki[2] = p3;
        }
        public Trojkat() : base()
        {
            Nazwa = "Trojkat Domyslny";
            Wierzcholki[0] = new Punkt("a", 0, 2);
            Wierzcholki[1] = new Punkt("b", -1, 0);
            Wierzcholki[2] = new Punkt("c", 1, 0);
        }

        public override Trojkat Clone()
        {
            return new Trojkat(Nazwa, Wierzcholki[0], Wierzcholki[1], Wierzcholki[2]);
        }
        public override double Obwod()
        {
            return Punkt.Odleglosc(Wierzcholki[0], Wierzcholki[1]) + Punkt.Odleglosc(Wierzcholki[1], Wierzcholki[2]) + Punkt.Odleglosc(Wierzcholki[2], Wierzcholki[0]);
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object? obj)
        {
            var item = obj as Trojkat;
            if (this.Wierzcholki[0] == item.Wierzcholki[0] && this.Wierzcholki[1] == item.Wierzcholki[1] && this.Wierzcholki[2] == item.Wierzcholki[2])
            { 
                return true;
            }
            return false;
        }
        public override void Przesun(double x, double y)
        {
            foreach (Punkt punkt in Wierzcholki)
            {
                punkt.Przesun(x, y);
            }
        }

        public static bool operator <(Trojkat trojkat1, Trojkat trojkat2)
        {
            if (trojkat1.Obwod() < trojkat2.Obwod())
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Trojkat trojkat1, Trojkat trojkat2)
        {
            if (trojkat1.Obwod() > trojkat2.Obwod())
            {
                return true;
            }
            return false;
        }
    }
}
