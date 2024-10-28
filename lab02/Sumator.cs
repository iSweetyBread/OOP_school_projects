using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Sumator
    {
        private float[] Liczby;

        public Sumator(float[] Liczby)
        { 
            this.Liczby = Liczby;
        }

        public float Suma()
        {
            float suma = 0;
            for (int i = 0; i < this.Liczby.Length; i++)
            {
                suma += this.Liczby[i];
            }
            return suma;
        }
        public float SumaPodziel2()
        {
            float suma = 0;
            for (int i = 0; i < this.Liczby.Length; i++)
            {
                suma += this.Liczby[i]/2;
            }
            return suma;
        }
        public int IleElementow() 
        { 
            return this.Liczby.Length;
        }
        public void WszystkieElementy()
        {
            Console.WriteLine("Elementy tablicy: ");
            for (int i = 0; i < this.Liczby.Length; i++)
            { 
                Console.Write($"{this.Liczby[i]}, ");
            }
        }
        public void ElementyMiedzy(int lowIndex, int highIndex)
        {
            Console.WriteLine($"Elementy tablicy między {lowIndex} indeksem a {highIndex} indeksem");
            if (highIndex > this.Liczby.Length) { highIndex = this.Liczby.Length - 1; }
            if (lowIndex < 0) { lowIndex = 0; }
            if (highIndex < 0) { highIndex = 0; }
            if ((highIndex < lowIndex)) { Console.WriteLine("Wpisane niepoprawne indeksy"); }
            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.Write($"{this.Liczby[i]}, ");
            }
        }
    }
}
