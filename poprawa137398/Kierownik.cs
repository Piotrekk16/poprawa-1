using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa137398
{
    class Kierownik : Osoba, INadgodziny
    {
        private int iloscPodwladnych;
        public override int ObliczPensje()
        {
            return base.ObliczPensje() + iloscPodwladnych * 7;
        }
        public Kierownik(string imie,string nazwisko,int podstawa,int podwaldni)
            :base(imie,nazwisko,podstawa)
        {
            this.iloscPodwladnych = podwaldni;
        }
        public override string ToString()
        {
            return string.Format("Kierownik: {0} {1}, podstawa {2}, ilosc podwaldnych  {3}.", imie, nazwisko, podstawa, iloscPodwladnych);
        }

        public override int DoliczNadgodziny(int cos)
        {
            return ObliczPensje() +cos*25;
        }
    }
}
