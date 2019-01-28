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
        public Kalendar Kalendar { get; }
        public bool Hide { get; }

        public Mjesta(int _id_mjesta, string _naziv_mjesta, string _adresa, List<DateTime> _datumi, bool _hide)
        {
            Kalendar = new Kalendar();
            Kalendar.Id_mjesta = _id_mjesta;
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Kalendar.Datumi = _datumi;
            Hide = _hide;
            Dodaj();
        }

        public Mjesta(string _naziv_mjesta, string _adresa, bool _hide)
        {
            Kalendar = new Kalendar();
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Hide = _hide;
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
                {"Adresa", Adresa },
                {"Sakriveno", Hide }
            };
            if((int)Kalendar.Id_mjesta <=0)
                Kalendar.Id_mjesta = Set("Mjesta", "NazivMjesta,Adresa", dictionary_stupci, true);
            else
                Set("Mjesta", "NazivMjesta,Adresa", dictionary_stupci, true);
            if (Kalendar.Datumi != null)
                if(Kalendar.Datumi.Any())
                new Kalendar(Kalendar.Id_mjesta, Kalendar.Datumi, false);
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
