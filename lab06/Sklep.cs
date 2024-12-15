using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Sklep
    {
        public enum StatusZamowienia
        { 
            Oczekujace = 1,
            Przyjete = 2,
            Zrealizowane = 3,
            Anulowane = 4,
        }
        public Dictionary<int, (List<string>, StatusZamowienia)> Zamowienia = new Dictionary<int, (List<string>, StatusZamowienia)>();

        public Sklep() { }

        public void start()
        {
            Console.WriteLine("\n\nMożliwe operacje:\n\t1. Wyświetl wszystkie zamówienia\n\t2. Zmień status zamówienia\n\t3. Dodaj nowe zamówienie\n\t4. Exit");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "1":
                    this.WyswietlZamowienia();
                    break;
                case "2":
                    this.ZmienStatus();
                    break;
                case "3":
                    this.DodajZamowienie();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Nieoczekiwana odpowiedź. Spróbuj ponownie\n\n");
                    this.start();
                    break;
            }
        }
        public void WyswietlZamowienia()
        {
            if (Zamowienia.Count == 0)
            {
                Console.WriteLine("Brak Zamówień");
                this.start();
            }

            Console.WriteLine("\n\nWszystkie zamówienia:");
            foreach (var item in Zamowienia)
            {
                Console.Write($"\t{item.Key}. Produkty: ");
                foreach (var item1 in item.Value.Item1)
                {
                    Console.Write(item1);
                }
                Console.WriteLine($"\tStatus: {item.Value.Item2}");
            }

            this.start();
        }
        public void DodajZamowienie()
        { 
            Console.WriteLine("\n\nWpisz produkty poniżej; żeby skończyć, wpisz \"exit\"");
            
            List<string> lista = new List<string>();
            while (true) 
            { 
                string input = Console.ReadLine();
                if (input is null)
                {
                    continue;
                }
                else if (input.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    lista.Add(input);
                }
            }
            
            try
            {
                this.Zamowienia.Add(Zamowienia.Keys.Last() + 1, (lista, StatusZamowienia.Oczekujace));
            }
            catch (System.InvalidOperationException)
            {
                this.Zamowienia.Add(1, (lista, StatusZamowienia.Oczekujace));
            }
            
            this.start();
        }
        public void ZmienStatus()
        {
            try
            {
                Console.WriteLine("\nPodaj numer zamówienia poniżej; żeby skończyć, wpisz \"exit\"");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    this.start();
                }

                int numer = int.Parse(input);
                if (!Zamowienia.ContainsKey(numer))
                {
                    Console.WriteLine($"\nZamowienia {numer} nie istnieje");
                    this.ZmienStatus();
                }

                Console.WriteLine("\nDostępne statusy: ");
                foreach (var i in Enum.GetValues(typeof(StatusZamowienia)))
                {
                    Console.WriteLine($"\t{i}");
                }

                Console.WriteLine("\nPodaj nowy status: ");
                string status = Console.ReadLine();
                if (!Enum.TryParse(status, out StatusZamowienia newStatus))
                {
                    Console.WriteLine("Nieprawidłowy status");
                    this.ZmienStatus();
                }

                if (Zamowienia[numer].Item2 == newStatus)
                {
                    throw new ArgumentException("Ten sam status");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.ZmienStatus();
            }
            this.start();
        }
    }
}
