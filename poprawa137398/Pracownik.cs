using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa137398
{
    class Pracownik : Osoba,INadgodziny, ICloneable
    {
        private int staz;
        public override int ObliczPensje()
        {
            return base.ObliczPensje() + staz * 100;
        }
        public Pracownik(string imie,string nazwisko,int podstawa, int staz)
            :base(imie, nazwisko,podstawa)
        {
            this.staz = staz;

        }
        public override string ToString()
        {
            return string.Format("Pracownik: {0} {1}, podstawa {2}, staz {3}.", imie, nazwisko, podstawa, staz);
        }


        public override int DoliczNadgodziny(int cos)
        {
            return ObliczPensje()+cos*15;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
