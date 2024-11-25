using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    public class Kolo : Ksztalt, IKonsola
    {
        public Punkt Srodek { get; set; }
        public double Promien { get; set; }

        public Kolo(string nazwa, Punkt srodek, double promien) : base(nazwa)
        { 
            Nazwa = nazwa;
            Srodek = srodek;
            Promien = promien;
        }
        public Kolo() : base()
        {
            Nazwa = "Kolo Domyslne";
            Srodek = new Punkt();
            Promien = 1;
        }

        public override Kolo Clone()
        {
            return new Kolo(Nazwa, Srodek, Promien);
        }
        public override double Obwod()
        {
            return (2 * Math.PI * Promien);
        }
        public override string ToString()
        {
            return "Kolo: " + Nazwa + "Centrum: \"" + Srodek.ToString() + "\" Promien: " + Promien.ToString();
        }
        public override bool Equals(object? obj)
        {
            var item = obj as Kolo;
            if (this.Srodek.Equals(item.Srodek) && this.Promien == item.Promien)
            { 
                return true;
            }
            return false;
        }
        public override void Przesun(double x, double y)
        {
            Srodek.Przesun(x, y);
        }
        public void Czytac()
        {
            Console.WriteLine("Podaj współrzędną X środka koła: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną Y środka koła: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Srodek = new Punkt("srodek", x, y);
            Console.WriteLine("Podaj długość promieniu: ");
            Promien = Convert.ToDouble(Console.ReadLine());
        }
        public void Wypisywac()
        { 
            Console.WriteLine("Centrum koła jest: ");
            Console.WriteLine(Srodek.ToString());
            Console.WriteLine("Długość promieniu jest: ");
            Console.WriteLine(Promien);
        }

        public static bool operator <(Kolo kolo1, Kolo kolo2)
        {
            if (kolo1.Obwod() < kolo2.Obwod())
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Kolo kolo1, Kolo kolo2)
        {
            if (kolo1.Obwod() > kolo2.Obwod())
            {
                return true;
            }
            return false;
        }
    }
}
