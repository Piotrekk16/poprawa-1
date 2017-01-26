using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa137398
{
    abstract class Osoba
    {
        protected string nazwisko;
        protected string imie;
        protected int podstawa;

        virtual public int ObliczPensje()
        {
            return podstawa;
        }

        public Osoba(string imie_,string nazwisko_,int podstawa_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
            this.podstawa = podstawa_;
        }

    }
}
