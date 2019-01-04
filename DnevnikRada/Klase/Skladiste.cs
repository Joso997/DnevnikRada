using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnevnikRada.Interface;
using System.Data;
using System.Windows.Forms;

namespace DnevnikRada.Klase
{
    class Skladiste : Baza.DB, IUseDatabase
    {
        
        public string Naziv_materijala{ get; private set;}
        public string Proizvodac { get; private set; }
        public string Mjerna_jedinica { get; private set; }
        public int Kolicina { get; set; }
        //private Baza.DB baza = new Baza.DB();


        // mozda bi trebalo u konstruktor stavit samo ono sto je obavezno? recimo d su 
        public Skladiste(string _naziv_materijala, string _proizvodac, string _mjerna_jedinica, int _kolicina)
        {
            Naziv_materijala = _naziv_materijala;
            Proizvodac = _proizvodac;
            Mjerna_jedinica = _mjerna_jedinica;
            Kolicina = _kolicina;
            Dodaj();
        }

        public Skladiste()
        {

        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMaterijala", Naziv_materijala },
                {"Prodavac", Proizvodac },
                {"Kolicina", Mjerna_jedinica },
                {"MjernaJedinica", Kolicina },
            };
            Set("Skladiste", dictionary_stupci, true);
        }

        public DataTable Ucitaj()
        {
            return Get("Skladiste");
        }

        public DataTable Ucitaj(string naziv_stupca, string trazi)
        {
            return Get("Skladiste", naziv_stupca, trazi);
        }

        public DataTable Ucitaj(int trazi)
        {
            return Get("Skladiste", trazi);
        }
    }
}
