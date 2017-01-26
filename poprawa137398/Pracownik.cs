using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa137398
{
    class Pracownik : Osoba
    {
        private int staz;
        public override int ObliczPensje()
        {
            return base.ObliczPensje() + staz * 100;
        }
        public Pracownik(string imie,string nazwisko,int podstawa, int staz)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.podstawa = podstawa;
            this.staz = staz;

        }
        public override string ToString()
        {
            return string.Format("Pracownik: {0} {1}, podstawa {2}, staz {3}.", imie, nazwisko, podstawa, staz);
        }

    }
}
