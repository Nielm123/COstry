using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class StudentUR : Student
    {
        public StudentUR(string imie, string nazwisko, string Uczelnia, string Kierunek, string Rok,
            string Semestr) : base(imie, nazwisko, Uczelnia, Kierunek, Rok, Semestr) { }
        public String WypiszPelnaNazweIUczelnie()
        {

        }
    }
}
