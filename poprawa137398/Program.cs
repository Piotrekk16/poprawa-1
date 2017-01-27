using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa137398
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> pracownicy = new List<Osoba>();

            pracownicy.Add(new Kierownik("jan", "kowalski", 120, 70));
            pracownicy.Add(new Pracownik("zygmunt", "trzeci", 80, 4));
            pracownicy.Add(new Kierownik("Anna", "Nowak", 1233, 32));
            pracownicy.Add(new Pracownik("zygmunt1", "trzeci", 80, 4));
            pracownicy.Add(new Kierownik("jan2", "kowalski", 120, 70));
            pracownicy.Add(new Pracownik("zygmunt2", "trzeci", 80, 4));
            pracownicy.Add(new Kierownik("jan3", "kowalski", 120, 70));
            pracownicy.Add(new Pracownik("zygmunt3", "trzeci", 80, 4));
            pracownicy.Add(new Kierownik("jan4", "Sloneczny", 120, 70));
            pracownicy.Add(new Pracownik("zygmunt4", "trzeci", 80, 4));

            for (int i = 1; i < pracownicy.Count - 1; i += 2)
            {
                Console.WriteLine(pracownicy[i].ObliczPensje());
            }
            pracownicy.RemoveAt(2);
            pracownicy.RemoveAt(6);

            foreach (var itm in pracownicy)
            {
                Console.WriteLine(itm.ToString());
            }

            //kod z polecenia 7
            for (int i = 0; i < pracownicy.Count;i++ )
            {
                Console.WriteLine(pracownicy[i].DoliczNadgodziny(i));
            }

            //kod z polecenia 9
            pracownicy.Sort();
            foreach(var element in pracownicy)
            {
                Console.WriteLine(element.ToString());
            }

            //kod z polecenia 10
            Pracownik doKopiowania = pracownicy[1] as Pracownik;
            Pracownik kopiaPracownika = (Pracownik)doKopiowania.Clone();

            Console.ReadKey();


        }
    }
}
