using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class App
    {
        static void Main(string[] args)
        {
            List<Osoba> listaosob = new List<Osoba>();
            Osoba osoba1 = new Osoba("Marian", "Mak");
            Osoba osoba2 = new Osoba("Miosz", "Lakowiak");
            Osoba osoba3 = new Osoba("Justyna", "Kowalczyk");

            listaosob.Add(osoba1);
            listaosob.Add(osoba2);
            listaosob.Add(osoba3);
            Console.WriteLine("Wszystkie osoby: ");
            listaosob.WypiszOsoby();
            Console.WriteLine("Wszystkie osoby posortowane: ");
            listaosob.PosortujOsobyPoNazwisku();
            listaosob.WypiszOsoby();


            List<StudentUR> listastudentow = new List<StudentUR>();
            StudentUR s1 = new StudentUR("Maciek", "Hel", "UR", "Inf", "2019", "3");
            StudentUR s2 = new StudentUR("Marianna", "Matolik", "PRZ", "Budowa", "2020", "1");
            StudentUR s3 = new StudentUR("Anna", "Kimchi", "Harvard", "Exp", "2017", "5");

            listastudentow.Add(s1);
            listastudentow.Add(s2);
            listastudentow.Add(s3);

            Console.WriteLine("Wszyscy studenci: ");
            Console.WriteLine(listastudentow.WypiszPelnaNazweIUczelnie()); ;

        }
    }
}

