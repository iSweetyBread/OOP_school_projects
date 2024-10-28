using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class BankAccount
    {
        public string Wlasciciel;
        public decimal Saldo { get; private set; }

        public BankAccount(string wlasciciel, decimal saldo) {
            this.Wlasciciel = wlasciciel;
            this.Saldo = saldo;
        }
        
        public void Wplata(decimal kwota)
        {
            Saldo += kwota;
        }
        public void Wyplata(decimal kwota)
        {
            if (Saldo < kwota)
            {
                Console.WriteLine("Niewystarczająca ilość środków");
            }
            else
            {
                Saldo -= kwota;
            }
        }
    }
}
