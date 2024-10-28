using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Student
    {
        public string imie;
        public string nazwisko;
        public float[] oceny;
        public float sredniaOcen;

        public Student(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.oceny = new float[0];
            this.sredniaOcen = SredniaOcen(oceny);
        }

        public static float SredniaOcen(float[] oceny)
        {
            if (oceny.Length == 0)
            {
                return 0;
            }
            float sum = 0;
            for (int i = 0; i < oceny.Length; i++)
            {
                sum += oceny[i];
            }
            return sum / oceny.Length;
        }

        public void DodajOcene(int ocena)
        {
            Array.Resize(ref oceny, oceny.Length + 1);
            oceny[oceny.Length - 1] = ocena;
            this.sredniaOcen = SredniaOcen(oceny);
        }
    }
}
