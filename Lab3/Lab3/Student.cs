using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Student : IStudent
    {
        private string imie;
        private string nazwisko;
        private string Uczelnia;
        private string Kierunek;
        private string Rok;
        private string Semestr;
        public String WypiszPelnaNazweIUczelnie()
        {
            return ZwrocPelnaNazwe()+ " " + this.Semestr + this.Kierunek + " " + this.Rok + " " + this.Uczelnia;
        }

        public Student(string imie, string nazwisko,string Uczelnia, string Kierunek, string Rok, string Semestr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Uczelnia = Uczelnia;
            this.Kierunek = Kierunek;
            this.Rok = Rok;
            this.Semestr = Semestr;
        }
        public Student()
        {

        }
        public void setImie(string imie)
        {
            this.imie=imie;
        }
        public void setNazwisko(string nazwisko)
        {
            this.nazwisko=nazwisko;
        }
        public void setUczelnia(string Uczelnia)
        {
            this.Uczelnia=Uczelnia;
        }
        public void setKierunek(string Kierunek)
        {
            this.Kierunek=Kierunek;
        }
        public void setRok(string Rok)
        {
            this.Rok=Rok;
        }
        public void setSemestr(string Semestr)
        {
            this.Semestr=Semestr;
        }
        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

    }
}
