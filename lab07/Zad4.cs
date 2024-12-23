using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab07
{
    public class Zad4
    {
        public class indicator
        {
            public string id { get; set; }
            public string value { get; set; }
        }
        public class country
        {
            public string id { get; set; }
            public string value { get; set; }
        }
        public class Population
        { 
            public indicator indicator { get; set; }
            public country country { get; set; }
            public string value { get; set; }
            public string @decimal { get; set; }
            public string date { get; set; }
        }

        public static List<Population> Odczyt()
        {
            string path = "db.json";
            string info = File.ReadAllText(path);
            List<Population> data = JsonSerializer.Deserialize<List<Population>>(info);
            return data;
        }
        public static (int, bool) Number(int rok, string kraj)
        {
            List<Population> data = Zad4.Odczyt();
            List<Population> parsed = data.FindAll(i => i.country.value == kraj);
            if (parsed.Count == 0)
            {
                Console.WriteLine($"Danych o kraju {kraj} nie istnieje");
                return (0, false);
            }

            Population? pop = parsed.Find(i => int.Parse(i.date) == rok);
            if (pop is null)
            {
                Console.WriteLine($"Danych o roku {rok} dla kraju {kraj} nie istnieje");
                return (0, false);
            }

            int liczba = int.Parse(pop.value);
            return (liczba, true);
        }

        public static void Populacja(int rok, string kraj)
        { 
            var data = Zad4.Number(rok, kraj);
            if (data.Item2)
            {
                Console.WriteLine($"Populacja kraju {kraj} w roku {rok} wynosiła {data.Item1}");
            }
        }

        public static void Roznica(int data1, int data2, string kraj)
        { 
            var pop1 = Zad4.Number(data1, kraj);
            var pop2 = Zad4.Number(data2, kraj);

            if (pop1.Item2 && pop2.Item2)
            {
                int diff = pop1.Item1 - pop2.Item1;
                if (diff > 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} zmniejszyła się o {Math.Abs(diff)} między rokami {data1} a {data2}");
                }
                else if (diff < 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} zwiększyła się o {Math.Abs(diff)} między rokami {data1} a {data2}");
                }
                else if (diff == 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} nie zmieniła się między rokami {data1} a {data2}");
                }
            }
            else
            {
                return;
            }
        }

        public static void Procent(int rok, string kraj)
        {
            var pop1 = Zad4.Number(rok, kraj);
            var pop2 = Zad4.Number(rok-1, kraj);

            if (pop1.Item2 && pop2.Item2)
            {
                float liczba1 = pop1.Item1;
                float liczba2 = pop2.Item1;
                float increase = ((liczba1 - liczba2) / liczba2) * 100;
                if (increase > 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} zwiększyła się o {increase}% między rokiem {rok} a poprzednim");
                }
                else if (increase < 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} Zmniejszyła się o {increase}% między rokiem {rok} a poprzednim");
                }
                else if (increase == 0)
                {
                    Console.WriteLine($"Populacja kraju {kraj} nie zmieniła się między rokiem {rok} a poprzednim");
                }
            }
            else
            {
                return;
            }
        }
    }
}
