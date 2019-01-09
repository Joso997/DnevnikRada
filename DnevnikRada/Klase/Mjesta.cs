using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;

namespace DnevnikRada.Klase
{
    class Mjesta : Baza.DB, IUseDatabase
    {

        public string Naziv_mjesta { get; private set; }
        public string Adresa { get; private set; }

        //vrijeme rada od do sta to tocno mora bit u bazi tj koji tip podatka

        public Mjesta(string _naziv_mjesta, string _adresa)
        {
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Dodaj();
        }

        public Mjesta()
        {

        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMjesta", Naziv_mjesta },
                {"Adresa", Adresa }
            };
            Set("Mjesta", "NazivMjesta,Adresa", dictionary_stupci, true);
        }

        public DataTable Ucitaj()
        {
            return Get("Mjesta");
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Mjesta", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(int trazi)
        {
            return Get("Mjesta", trazi);
        }


    }
}
