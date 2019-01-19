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

        public Mjesta(string _naziv_mjesta, string _adresa, DateTime _od_vrijemeRada, DateTime _do_vrijemeRada)
        {
            Naziv_mjesta = _naziv_mjesta;
            Adresa = _adresa;
            Od_VrijemeRada = _od_vrijemeRada;
            Do_VrijemeRada = _do_vrijemeRada;
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
                {"Adresa", Adresa },
                {"VrijemeRadaOD", Od_VrijemeRada != DateTime.MinValue ? Od_VrijemeRada.ToString("yyyy-MM-dd HH:mm:ss"): null },
                {"VrijemeRadaDO", Do_VrijemeRada != DateTime.MinValue ? Do_VrijemeRada.ToString("yyyy-MM-dd HH:mm:ss"): null }
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
