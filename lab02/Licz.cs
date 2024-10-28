using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Licz
    {
        private int value;

        public Licz(int value) 
        {
            this.value = value;
        }

        public void Dodaj(int a)
        { 
            this.value += a;
        }
        public void Odejmij(int a)
        {
            this.value -= a;
        }
        public void Stan() 
        {
            Console.WriteLine($"Liczba wynosi: {value}");
        }
    }
}
