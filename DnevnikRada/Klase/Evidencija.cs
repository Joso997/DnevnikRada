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
        public string Materijal { get; set; }
        public int Kolicina { get; set; }
        public double Cijena { get; set; }
        public string Opis_Posla { get; set; }
        public int Utroseno_Vrijeme { get; set; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        public Evidencija(string _nazivMjesta, DateTime _datum, string  _opisPosla, int _utrosenoVrijeme, string _materijal, int _kolicina, double _cijena)
        {
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum; ;
            Materijal = _materijal;
            Kolicina = _kolicina;
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
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>();
            dictionary_stupci.Add("NazivMjesta", Naziv_Mjesta);
            dictionary_stupci.Add("Datum", Datum.ToString("yyyy-MM-dd HH:mm:ss"));
            dictionary_stupci.Add("Materijal", Materijal);
            dictionary_stupci.Add("Kolicina", Kolicina);
            dictionary_stupci.Add("Cijena", Cijena);
            dictionary_stupci.Add("OpisPosla", Opis_Posla);
            dictionary_stupci.Add("UtrosenoVrijeme", Utroseno_Vrijeme);
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
