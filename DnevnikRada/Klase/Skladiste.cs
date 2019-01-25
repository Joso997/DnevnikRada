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
        
        public string Naziv_materijala{ get;}
        public string Proizvodac { get; }
        public string Mjerna_jedinica { get; }
        public int Cijena { get; }


        // mozda bi trebalo u konstruktor stavit samo ono sto je obavezno? recimo d su 
        public Skladiste(string _naziv_materijala, string _proizvodac, string _mjerna_jedinica, int _cijena)
        {
            Naziv_materijala = _naziv_materijala;
            Proizvodac = _proizvodac;
            Mjerna_jedinica = _mjerna_jedinica;
            Cijena = _cijena;
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
                {"MjernaJedinica", Mjerna_jedinica },
                {"Cijena", Cijena }
            };
            Set("Skladiste", dictionary_stupci, true);
        }

        public DataTable Ucitaj()
        {
            return Get("Skladiste");
        }

        public DataTable Ucitaj(int _id)
        {

            return Get("Skladiste", new Dictionary<string, object> { { "ID", _id } }, new List<string> { { "=" } });
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Skladiste", biblioteka, _operator);
        }
    }
}
