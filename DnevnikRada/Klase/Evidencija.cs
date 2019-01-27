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
        public int Sifra { get; }
        public string Naziv_Mjesta { get; }
        public DateTime Datum { get; }
        public double Cijena { get; }
        public string Opis_Posla { get; }
        public int Utroseno_Vrijeme { get; }
        public Poveznica Poveznica { get; }
        public bool Hide { get; }

        //ono sto je potrebno u evidenciji <<datum, opis posla, utroseno vrijeme>> ostalo moze bit null
        //materijal i kolicina prebacena u poveznicu jer nije potrebno ovdje
        public Evidencija(string _nazivMjesta, DateTime _datum, string  _opisPosla, int _utrosenoVrijeme, Dictionary<string,int> _informacije, bool _hide)
        {
            Poveznica = new Poveznica();
            Sifra = -1;
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum;
            Opis_Posla = _opisPosla;
            Utroseno_Vrijeme = _utrosenoVrijeme;
            Poveznica.Informacije = _informacije;
            Hide = _hide;
            Dodaj();
        }

        public Evidencija(int _sifra, string _nazivMjesta, DateTime _datum, string _opisPosla, int _utrosenoVrijeme, bool _hide)
        {
            Poveznica = new Poveznica();
            Sifra = _sifra;
            Naziv_Mjesta = _nazivMjesta;
            Datum = _datum;
            Opis_Posla = _opisPosla;
            Utroseno_Vrijeme = _utrosenoVrijeme;
            Poveznica.Informacije = new Dictionary<string, int>();
            Hide = _hide;
            Dodaj();
        }

        public Evidencija()
        {
            Poveznica = new Poveznica();
        }

        private void Dodaj()
        {
            Dictionary<string, object> dictionary_stupci = new Dictionary<string, object>
            {
                {"NazivMjesta", Naziv_Mjesta },
                {"Datum", Datum.ToString("yyyy-MM-dd HH:mm:ss") },
                {"OpisPosla", Opis_Posla },
                {"UtrosenoVrijeme", Utroseno_Vrijeme },
                {"Id_Mjesta", Naziv_Mjesta != ""?new Mjesta().Ucitaj(new Dictionary<string, object>{{"NazivMjesta", Naziv_Mjesta }}, new List<string> {{"="}}).Rows[0]["ID"]:"" },
                {"Sakriveno", Hide }
            };
            if(Poveznica.Informacije.Count != 0 || Sifra == -1)
            {
                Poveznica.Id_evidencija = Set("Evidencija", dictionary_stupci, false);
                new Poveznica(Poveznica.Id_evidencija, Poveznica.Informacije);
            }
            else
            {
                dictionary_stupci.Add("Sifra", Sifra);
                Set("Evidencija", "Sifra", dictionary_stupci, true);
            }
                   
        }

        public DataTable Ucitaj()
        {
            return Get("Evidencija");
        }

        public DataTable Ucitaj(int _id)
        {
            return Get("Evidencija", new Dictionary<string, object> { { "ID", _id } }, new List<string> { { "=" } });
        }

        public DataTable Ucitaj(Dictionary<string, object> biblioteka, List<string> _operator)
        {
            return Get("Evidencija", biblioteka, _operator);
        }

        public bool Provjera(string naziv, int kolicina)
        {
            return ProvjeraNegativnosti(naziv, kolicina);
        }
    }
}
