using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IStudent : IOsoba
    {
        void setImie(String imie);
        void setNazwisko(String nazwisko);
        void setUczelnia(String uczelnia);
        void setKierunek(String kierunek);
        void setRok(String rok);
        void setSemestr(String semestr);
    }
}
