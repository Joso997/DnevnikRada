using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DnevnikRada.Interface;

namespace DnevnikRada.Klase
{
    class Evidencija : Baza.DB, IUseDatabase
    {
        public string Naziv_Mjesta { get; set; }
        public DateTime Datum { get; set; }
        public double Cijena { get; set; }
        public string Opis_Posla { get; set; }
        public int Utroseno_Vrijeme { get; set; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        //materijal i kolicina prebacena u poveznicu jer nije potrebno ovdje
        public Evidencija(string _nazivMjesta, DateTime _datum, string  _opisPosla, int _utrosenoVrijeme, double _cijena)
        {
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum;

            Cijena = _cijena;
            Opis_Posla = _opisPosla;
            Utroseno_Vrijeme = _utrosenoVrijeme;
            Dodaj();
        }
        public Evidencija()
        {

        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMjesta", Naziv_Mjesta },
                {"Datum", Datum.ToString("yyyy-MM-dd HH:mm:ss") },
                {"Cijena", Cijena },
                {"OpisPosla", Opis_Posla },
                {"UtrosenoVrijeme", Utroseno_Vrijeme }
            };
            Set("Evidencija", dictionary_stupci);
        }

        public DataTable Ucitaj()
        {
            return Get("Evidencija");
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Evidencija", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(int trazi)
        {
            return Get("Evidencija", trazi);
        }

        
    }
}
