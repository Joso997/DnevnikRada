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
        public string Naziv_mjesta { get; }
        public string Adresa { get; }
        public DateTime Od_VrijemeRada { get; }
        public DateTime Do_VrijemeRada { get; }
        public Kalendar Kalendar { get; }

        public Mjesta(string _naziv_mjesta, string _adresa, List<DateTime> _datumi)
        {
            Kalendar = new Kalendar();
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Kalendar.Datumi = _datumi;
            Dodaj();
        }

        public Mjesta(string _naziv_mjesta, string _adresa)
        {
            Kalendar = new Kalendar();
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Dodaj();
        }

        public Mjesta()
        {
            Kalendar = new Kalendar();
        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMjesta", Naziv_mjesta },
                {"Adresa", Adresa }
            };
            Kalendar.Id_mjesta = Set("Mjesta", "NazivMjesta,Adresa", dictionary_stupci, true);
            if(Kalendar.Datumi.Any())
                new Kalendar(Kalendar.Id_mjesta, Kalendar.Datumi);
        }

        public DataTable Ucitaj()
        {
            return Get("Mjesta");
        }

        public DataTable Ucitaj(int _id)
        {
            
            return Get("Mjesta", new Dictionary<string, object>{{"ID", _id }}, new List<string> { { "=" } });
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Mjesta", biblioteka, _operator);
        }


    }
}
