using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Samochod
    {
        protected string marka;
        protected string model;
        protected string nadwozie;
        protected string kolor;
        protected int rokProdukcji;
        protected int przebieg;

        public int Przebieg 
        {
            get { return przebieg; }
            set 
            {
                if (value < 0)
                { 
                    throw new ArgumentOutOfRangeException(nameof(value), "liczba musi być nie ujemna!");
                }
                przebieg = value;
            }
        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            this.marka = marka;
            this.model = model;
            this.nadwozie = nadwozie;
            this.kolor = kolor;
            this.rokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public virtual void info()
        {
            Console.WriteLine($"Informacje o samochodzie:\n\tMarka: {marka}\n\tModel: {model}\n\tNadwozie: {nadwozie}\n\tKolor: {kolor}\n\tRok Produkcji: {rokProdukcji}\n\tPrzebieg: {przebieg} km\n");
        }
    }
}
