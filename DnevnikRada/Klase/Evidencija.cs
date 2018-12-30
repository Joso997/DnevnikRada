using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnikRada.Klase
{
    class Evidencija : Baza.DB
    {
        public string NazivMjesta { get; set; }
        public DateTime Datum { get; set; }
        public string Materijal { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public string OpisPosla { get; set; }
        public int UtrosenoVrijeme { get; set; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        public Evidencija(DateTime datum, string opisPosla, int utrosenoVrijeme,
            string nazivMjesta,string materijal, int kolicina, double cijena)
        {
            Datum = datum;
            OpisPosla = opisPosla;
            UtrosenoVrijeme = utrosenoVrijeme;
            NazivMjesta = nazivMjesta;
            Materijal = materijal;
            Kolicina = kolicina;
            Cijena = cijena;
        }
    }
}
