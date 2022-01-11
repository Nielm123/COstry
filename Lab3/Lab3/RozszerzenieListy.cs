using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class RozszerzenieListy
    {
        public static void WypiszOsoby(this List<Osoba> listaosob)
        {
            foreach (Osoba osoba in listaosob)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }
        public static void PosortujOsobyPoNazwisku(this List<Osoba> listaosob)
        {
            listaosob.Sort((osoba1, osoba2) => osoba1.getNazwisko().CompareTo(osoba2.getNazwisko()));
        }
    }
}
