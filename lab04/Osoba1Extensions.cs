using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    public static class Osoba1Extensions
    {
        public static void WypiszOsobu(this List<IOsoba> osoby)
        {
            foreach (Osoba1 osoba in osoby)
            {
                osoba.ZwrocPelnaNazwe();
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
        {
            osoby.Sort((osoba1, osoba2) => string.Compare(osoba1.Nazwisko, osoba2.Nazwisko, StringComparison.Ordinal));
        }
    }
}
