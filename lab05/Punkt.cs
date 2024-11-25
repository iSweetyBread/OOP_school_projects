using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Punkt : Ksztalt
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt(string nazwa, double x, double y) : base(nazwa)
        { 
            Nazwa = nazwa;
            X = x;
            Y = y;
        }
        public Punkt() : base()
        {
            Nazwa = "Punkt Domyslny";
            X = 0;
            Y = 0;
        }

        public override Punkt Clone()
        { 
            return new Punkt(Nazwa, X, Y);
        }
        public override double Obwod()
        {
            return 0;
        }
        public override string ToString()
        {
            return "Punkt: " + Nazwa + "X: " + X.ToString() + "Y: " + Y.ToString();
        }
        public override bool Equals(object? obj)
        {
            var item = obj as Punkt;
            if (this.X == item.X && this.Y == item.Y)
            { 
                return true;
            }
            return false;
        }
        public void Wspolrzedne(double x, double y)
        { 
            this.X = x; 
            this.Y = y;
        }
        public override void Przesun(double x, double y)
        { 
            this.X += x;
            this.Y += y;
        }
        public static double Odleglosc(Punkt p1, Punkt p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
    }
}
